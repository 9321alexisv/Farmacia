
using Npgsql;
using System.Reflection;
using VistasFarmacia.Datos;
using VistasFarmacia.Entidad;

namespace Farmacia.Datos
{
    public class D_Ventas
    {
        // ============================================================================================
        // NUEVA VENTA ================================================================================
        // ============================================================================================
        public int CrearVenta(int idCliente)
        {
            ConexionDB conexion = new ConexionDB();
            NpgsqlConnection conn = conexion.AbrirConexion();
            string query = "INSERT INTO venta (id_cliente) VALUES (@idCliente) RETURNING id_venta;";

            try
            {
                NpgsqlCommand command = new NpgsqlCommand(query, conn);
                command.Parameters.AddWithValue("@idCliente", idCliente);

                int idVenta = Convert.ToInt32(command.ExecuteScalar());
                return idVenta;
            }
            catch (NpgsqlException ex)
            {
                throw new Exception("Error al insertar en la tabla 'venta'", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public void InsertarDetalleVenta(int idVenta, DataGridView dgvProductos)
        {
            ConexionDB conexion = new ConexionDB();
            NpgsqlConnection conn = conexion.AbrirConexion();
            string query = "INSERT INTO detalle_venta (id_venta, id_producto, precio_compra, precio_venta, cantidad) VALUES (@id_venta, @id_producto, @precio_compra, @precio_venta, @cantidad)";

            try
            {
                NpgsqlCommand command = new NpgsqlCommand(query, conn);

                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    command.Parameters.AddWithValue("@id_venta", idVenta);
                    command.Parameters.AddWithValue("@id_producto", Convert.ToInt32(row.Cells["codigo"].Value));
                    command.Parameters.AddWithValue("@precio_compra", Convert.ToDecimal(row.Cells["PrecioCompra"].Value));
                    command.Parameters.AddWithValue("@precio_venta", Convert.ToDecimal(row.Cells["Precio"].Value));
                    command.Parameters.AddWithValue("@cantidad", Convert.ToInt32(row.Cells["Cantidad"].Value));

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
            catch (NpgsqlException ex)
            {
                throw new Exception("Error al insertar en la tabla 'detalle_venta'" + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        // ============================================================================================
        // OBTENER TODAS LAS VENTAS ===================================================================
        // ============================================================================================
        public List<Venta> ObtenerVentas()
        {
            ConexionDB conexion = new ConexionDB();
            NpgsqlConnection conn = conexion.AbrirConexion();
            string query = "SELECT v.id_venta, c.nombre, v.fecha " +
                           "FROM venta v " +
                           "INNER JOIN cliente c ON v.id_cliente = c.id_cliente";

            try
            {
                NpgsqlCommand command = new NpgsqlCommand(query, conn);

                NpgsqlDataReader reader = command.ExecuteReader();
                List<Venta> ventas = new List<Venta>();

                while (reader.Read())
                {
                    Venta venta = new Venta
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
                throw new Exception("Error al obtener todas las ventas", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public List<DetalleVenta> ObtenerDetallesVenta(int idVenta)
        {
            ConexionDB conexion = new ConexionDB();
            NpgsqlConnection conn = conexion.AbrirConexion();
            string query = "SELECT p.id_producto, p.nombre, dv.precio_compra, dv.precio_venta, dv.cantidad " +
                           "FROM detalle_venta dv " +
                           "INNER JOIN producto p ON dv.id_producto = p.id_producto " +
                           "WHERE dv.id_venta = @idVenta";

            try
            {
                NpgsqlCommand command = new NpgsqlCommand(query, conn);
                command.Parameters.AddWithValue("@idVenta", idVenta);

                NpgsqlDataReader reader = command.ExecuteReader();
                List<DetalleVenta> detalleVenta = new List<DetalleVenta>();
                while (reader.Read())
                {
                    DetalleVenta detalle = new DetalleVenta
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
                throw new Exception("Error al obtener los detalles de la venta", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }
}
