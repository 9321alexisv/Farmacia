
using Npgsql;
using VistasFarmacia.Datos;
using VistasFarmacia.Entidad;

namespace Farmacia.Datos
{
    public class D_Compras
    {
        // ============================================================================================
        // CREAR COMPRA ===============================================================================
        // ============================================================================================
        public int CrearCompra()
        {
            ConexionDB conexion = new();
            NpgsqlConnection conn = conexion.AbrirConexion();

            string query = "INSERT INTO compra DEFAULT VALUES RETURNING id_compra;";

            try
            {
                NpgsqlCommand command = new(query, conn);
                int idCompra = Convert.ToInt32(command.ExecuteScalar());
                return idCompra;
            }
            catch (NpgsqlException ex)
            {
                throw new Exception("Error al insertar en la tabla 'compra'", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public void InsertarDetalleCompra(int idCompra, DataGridView dgvProductos)
        {
            ConexionDB conexion = new();
            NpgsqlConnection conn = conexion.AbrirConexion();
            string query = "INSERT INTO detalle_compra (id_compra, id_producto, precio_compra, precio_venta, cantidad) VALUES (@id_compra, @id_producto, @precio_compra, @precio_venta, @cantidad)";

            try
            {
                NpgsqlCommand command = new(query, conn);

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
                throw new Exception("Error al insertar en la tabla 'detalle_compra': " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        // ============================================================================================
        // ACTUALIZAR STOCK ===========================================================================
        // ============================================================================================
        public void ActualizarStockProductos(int idCompra, DataGridView dgvProductos)
        {
            ConexionDB conexion = new();
            NpgsqlConnection conn = conexion.AbrirConexion();

            try
            {
                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    int idProducto = Convert.ToInt32(row.Cells["codigo"].Value);
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

                    string queryUpdateStock = "UPDATE producto SET stock = stock + @cantidad WHERE id_producto = @idProducto";
                    NpgsqlCommand commandUpdateStock = new(queryUpdateStock, conn);
                    commandUpdateStock.Parameters.AddWithValue("@cantidad", cantidad);
                    commandUpdateStock.Parameters.AddWithValue("@idProducto", idProducto);
                    commandUpdateStock.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                throw new Exception("Error al actualizar el stock de los productos: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        // ============================================================================================
        // OBTENER TODAS LAS COMPRAS ==================================================================
        // ============================================================================================

        public List<Compra> ObtenerComprasPorFechas(DateTime? fechaInicio, DateTime? fechaFin)
        {
            ConexionDB conexion = new();
            NpgsqlConnection conn = conexion.AbrirConexion();

            string query = "SELECT c.id_compra, c.fecha FROM compra c WHERE c.fecha BETWEEN @fechaInicio AND @fechaFin ORDER BY fecha DESC;";

            try
            {
                NpgsqlCommand command = new(query, conn);
                command.Parameters.AddWithValue("@fechaInicio", fechaInicio.HasValue ? fechaInicio.Value : DateTime.MinValue.ToString());
                command.Parameters.AddWithValue("@fechaFin", fechaFin.HasValue ? fechaFin.Value : DateTime.Now.Date.ToString());

                NpgsqlDataReader reader = command.ExecuteReader();
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
                throw new Exception("Error al obtener compras por fechas", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public List<Compra> ObtenerCompras()
        {
            ConexionDB conexion = new();
            NpgsqlConnection conn = conexion.AbrirConexion();
            string query = "SELECT c.id_compra, c.fecha FROM compra c ORDER BY fecha DESC;";

            try
            {
                NpgsqlCommand command = new(query, conn);

                NpgsqlDataReader reader = command.ExecuteReader();
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
                throw new Exception("Error al obtener todas las compras", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public List<DetalleCompra> ObtenerDetallesCompra(int idCompra)
        {
            ConexionDB conexion = new();
            NpgsqlConnection conn = conexion.AbrirConexion();
            string query = "SELECT p.id_producto, pr.proveedor, p.nombre, dc.precio_compra, dc.cantidad " +
                           "FROM detalle_compra dc " +
                           "INNER JOIN producto p ON dc.id_producto = p.id_producto " +
                           "INNER JOIN proveedor pr ON pr.id_proveedor = p.id_proveedor " +
                           "WHERE dc.id_compra = @idCompra";

            try
            {
                NpgsqlCommand command = new(query, conn);
                command.Parameters.AddWithValue("@idCompra", idCompra);

                NpgsqlDataReader reader = command.ExecuteReader();
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
                throw new Exception("Error al obtener los detalles de la compra", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

    }
}
