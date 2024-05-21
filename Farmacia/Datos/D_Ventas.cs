
using Farmacia.Entidad;
using Npgsql;

namespace Farmacia.Datos
{
    public class D_Ventas
    {
        // ============================================================================================
        // NUEVA VENTA ================================================================================
        // ============================================================================================
        public static int CrearVenta(int idCliente)
        {
            string query = "INSERT INTO venta (id_cliente) VALUES (@idCliente) RETURNING id_venta;";

            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand command = new(query, conn);
                command.Parameters.AddWithValue("@idCliente", idCliente);
                int idVenta = Convert.ToInt32(command.ExecuteScalar());
                
                return idVenta;
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al insertar en la tabla 'venta'", ex);
            }
        }

        public static void InsertarDetalleVenta(int idVenta, DataGridView dgvProductos)
        {
            string query = "INSERT INTO detalle_venta (id_venta, id_producto, precio_compra, precio_venta, cantidad) VALUES (@id_venta, @id_producto, @precio_compra, @precio_venta, @cantidad)";

            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@id_venta", idVenta);
                cmd.Parameters.Add("@id_producto", NpgsqlTypes.NpgsqlDbType.Integer);
                cmd.Parameters.Add("@precio_compra", NpgsqlTypes.NpgsqlDbType.Numeric);
                cmd.Parameters.Add("@precio_venta", NpgsqlTypes.NpgsqlDbType.Numeric);
                cmd.Parameters.Add("@cantidad", NpgsqlTypes.NpgsqlDbType.Integer);

                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    if (row.IsNewRow) continue;
                    
                    cmd.Parameters["@id_producto"].Value = Convert.ToInt32(row.Cells["IdProducto"].Value);
                    cmd.Parameters["@precio_compra"].Value = Convert.ToDecimal(row.Cells["PrecioCompra"].Value);
                    cmd.Parameters["@precio_venta"].Value = Convert.ToDecimal(row.Cells["PrecioVenta"].Value);
                    cmd.Parameters["@cantidad"].Value = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    
                    cmd.ExecuteNonQuery();
                }

                ActualizarStockProductos(dgvProductos);
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al insertar en la tabla 'detalle_venta'" + ex.Message + ex);
            }
        }

        public static void ActualizarStockProductos(DataGridView dgvProductos)
        {
            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;

                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    int idProducto = Convert.ToInt32(row.Cells["IdProducto"].Value);
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

                    string query = "UPDATE producto SET stock = stock - @cantidad WHERE id_producto = @idProducto";

                    using NpgsqlCommand cmd = new(query, conn);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al actualizar el stock de los productos: " + ex.Message);
            }
        }

        // ============================================================================================
        // OBTENER TODAS LAS VENTAS ===================================================================
        // ============================================================================================
        public static List<Venta> ObtenerVentas()
        {
            string query = "SELECT v.id_venta, c.nombre, v.fecha " +
                           "FROM venta v " +
                           "INNER JOIN cliente c ON v.id_cliente = c.id_cliente";

            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand command = new(query, conn);
                using NpgsqlDataReader reader = command.ExecuteReader();
                List<Venta> ventas = [];

                while (reader.Read())
                {
                    Venta venta = new()
                    {
                        IdVenta = reader.GetInt32(0),
                        Cliente = reader.GetString(1),
                        Fecha = reader.GetDateTime(2).ToString(),
                    };

                    ventas.Add(venta);
                }

                return ventas;
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al obtener todas las ventas", ex);
            }
        }

        public static List<DetalleVenta> ObtenerDetallesVenta(int idVenta)
        {
            string query = "SELECT p.id_producto, p.nombre, dv.precio_compra, dv.precio_venta, dv.cantidad " +
                           "FROM detalle_venta dv " +
                           "INNER JOIN producto p ON dv.id_producto = p.id_producto " +
                           "WHERE dv.id_venta = @idVenta";

            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand command = new(query, conn);
                command.Parameters.AddWithValue("@idVenta", idVenta);
                using NpgsqlDataReader reader = command.ExecuteReader();

                List<DetalleVenta> detalleVenta = [];
                while (reader.Read())
                {
                    DetalleVenta detalle = new()
                    {
                        IdProducto = reader.GetInt32(0),
                        Producto = reader.GetString(1),
                        PrecioCompra = reader.GetDecimal(2),
                        PrecioVenta = reader.GetDecimal(3),
                        Cantidad = reader.GetInt32(4)
                    };

                    detalleVenta.Add(detalle);
                }

                return detalleVenta;
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al obtener los detalles de la venta", ex);
            }
        }

    }
}
