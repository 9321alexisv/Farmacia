
using Farmacia.Entidad;
using Npgsql;

namespace Farmacia.Datos
{
    public class D_Compras
    {
        // ============================================================================================
        // CREAR COMPRA ===============================================================================
        // ============================================================================================
        public static int CrearCompra()
        {
            string query = "INSERT INTO compra DEFAULT VALUES RETURNING id_compra;";

            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand command = new(query, conn);
                int idCompra = Convert.ToInt32(command.ExecuteScalar());
                
                return idCompra;
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al crear registro pivote.", ex);
            }
        }

        public static void InsertarDetalleCompra(int idCompra, DataGridView dgvProductos)
        {
            string query = "INSERT INTO detalle_compra (id_compra, id_producto, precio_compra, precio_venta, cantidad) VALUES (@id_compra, @id_producto, @precio_compra, @precio_venta, @cantidad)";

            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand command = new(query, conn);

                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    command.Parameters.AddWithValue("@id_compra", idCompra);

                    command.Parameters.AddWithValue("@id_producto", Convert.ToInt32(row.Cells["codigo"].Value));
                    command.Parameters.AddWithValue("@precio_compra", Convert.ToDecimal(row.Cells["PrecioCompra"].Value));
                    command.Parameters.AddWithValue("@precio_venta", Convert.ToDecimal(row.Cells["PrecioVenta"].Value));
                    command.Parameters.AddWithValue("@cantidad", Convert.ToInt32(row.Cells["Cantidad"].Value));

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al insertar en la tabla 'detalle_compra': " + ex.Message);
            }
        }

        // ============================================================================================
        // ACTUALIZAR STOCK ===========================================================================
        // ============================================================================================
        public static void ActualizarStockProductos(DataGridView dgvProductos)
        {
            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;

                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    int idProducto = Convert.ToInt32(row.Cells["codigo"].Value);
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

                    string query = "UPDATE producto SET stock = stock + @cantidad WHERE id_producto = @idProducto";

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
        // OBTENER TODAS LAS COMPRAS ==================================================================
        // ============================================================================================

        public static List<Compra> ObtenerComprasPorFechas(DateTime? fechaInicio, DateTime? fechaFin)
        {
            string query = "SELECT c.id_compra, c.fecha FROM compra c WHERE c.fecha BETWEEN @fechaInicio AND @fechaFin ORDER BY fecha DESC;";

            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand command = new(query, conn);
                command.Parameters.AddWithValue("@fechaInicio", fechaInicio.HasValue ? fechaInicio.Value : DateTime.MinValue.ToString());
                command.Parameters.AddWithValue("@fechaFin", fechaFin.HasValue ? fechaFin.Value : DateTime.Now.Date.ToString());

                using NpgsqlDataReader reader = command.ExecuteReader();
                List<Compra> compras = [];

                while (reader.Read())
                {
                    Compra compra = new()
                    {
                        IdCompra = reader.GetInt32(0),
                        Fecha = reader.GetDateTime(1).ToString(),
                    };

                    compras.Add(compra);
                }

                return compras;
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al obtener compras por fechas.", ex);
            }
        }

        public static List<Compra> ObtenerCompras()
        {
            string query = "SELECT c.id_compra, c.fecha FROM compra c ORDER BY fecha DESC;";

            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand command = new(query, conn);
                using NpgsqlDataReader reader = command.ExecuteReader();
                List<Compra> compras = [];

                while (reader.Read())
                {
                    Compra compra = new()
                    {
                        IdCompra = reader.GetInt32(0),
                        Fecha = reader.GetDateTime(1).ToString(),
                    };

                    compras.Add(compra);
                }

                return compras;
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al obtener todas las compras", ex);
            }
        }

        public static List<DetalleCompra> ObtenerDetallesCompra(int idCompra)
        {
            string query = "SELECT p.id_producto, pr.proveedor, p.nombre, dc.precio_compra, dc.cantidad " +
                           "FROM detalle_compra dc " +
                           "INNER JOIN producto p ON dc.id_producto = p.id_producto " +
                           "INNER JOIN proveedor pr ON pr.id_proveedor = p.id_proveedor " +
                           "WHERE dc.id_compra = @idCompra";

            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand command = new(query, conn);
                command.Parameters.AddWithValue("@idCompra", idCompra);

                using NpgsqlDataReader reader = command.ExecuteReader();
                List<DetalleCompra> detalleCompra = [];

                while (reader.Read())
                {
                    DetalleCompra detalle = new()
                    {
                        Proveedor = reader.GetString(1),
                        Producto = reader.GetString(2),
                        PrecioCompra = reader.GetDecimal(3),
                        Cantidad = reader.GetInt32(4)
                    };

                    detalleCompra.Add(detalle);
                }

                return detalleCompra;
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al obtener los detalles de la compra", ex);
            }
        }
    }
}
