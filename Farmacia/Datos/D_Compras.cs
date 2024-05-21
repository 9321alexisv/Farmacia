
using Farmacia.Entidad;
using Npgsql;
using System.Data;

namespace Farmacia.Datos
{
    public class D_Compras
    {
        // ============================================================================================
        // CREAR COMPRA ===============================================================================
        // ============================================================================================
        public static int CrearCompra(int idProveedor)
        {
            string query = "INSERT INTO compra (id_proveedor) VALUES (@id_proveedor) RETURNING id_compra;";

            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand command = new(query, conn);
                command.Parameters.AddWithValue("@id_proveedor", idProveedor);
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

                    command.Parameters.AddWithValue("@id_producto", Convert.ToInt32(row.Cells["IdProducto"].Value));
                    command.Parameters.AddWithValue("@precio_compra", Convert.ToDecimal(row.Cells["PrecioCompra"].Value));
                    command.Parameters.AddWithValue("@precio_venta", Convert.ToDecimal(row.Cells["PrecioVenta"].Value));
                    command.Parameters.AddWithValue("@cantidad", Convert.ToInt32(row.Cells["Cantidad"].Value));

                    command.ExecuteNonQuery();
                    //command.Parameters.Clear(); // Causa error de fk_detallecompra_producto
                }

                ActualizarStockProductos(dgvProductos);
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al insertar en la tabla 'detalle_compra'.", ex);
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
        public static List<Compra> ComprasPorFechas(DateTime? fechaInicio, DateTime? fechaFin)
        {
            List<Compra> compras = [];
            string query = """
                SELECT c.id_compra, p.id_proveedor, p.nombre proveedor, c.fecha 
                FROM compra c JOIN proveedor p ON c.id_proveedor = p.id_proveedor 
                WHERE c.fecha BETWEEN @fechaInicio AND @fechaFin
                ORDER BY fecha DESC;
                """;

            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio.HasValue ? fechaInicio.Value : DateTime.MinValue.ToString());
                cmd.Parameters.AddWithValue("@fechaFin", fechaFin.HasValue ? fechaFin.Value : DateTime.Now.Date.ToString());

                using NpgsqlDataReader datos = cmd.ExecuteReader();

                while (datos.Read())
                {
                    Compra compra = new()
                    {
                        IdCompra = datos.GetInt32("id_compra"),
                        Proveedor = new()
                        {
                            IdProveedor = datos.GetFieldValue<int>("id_proveedor"),
                            Nombre = datos.GetFieldValue<string>("proveedor"),
                        },
                        Fecha = datos.GetFieldValue<DateTime>("fecha").ToString(),
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
            List<Compra> compras = [];
            string query = """
                SELECT c.id_compra, p.id_proveedor, p.nombre proveedor, c.fecha 
                FROM compra c JOIN proveedor p ON c.id_proveedor = p.id_proveedor 
                ORDER BY fecha DESC;
                """;

            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand command = new(query, conn);
                using NpgsqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Compra compra = new()
                    {
                        IdCompra = reader.GetInt32(0),
                        Proveedor = new()
                        {
                            IdProveedor = reader.GetInt32("id_proveedor"),
                            Nombre = reader.GetString("proveedor"),
                        },
                        Fecha = reader.GetDateTime("fecha").ToString(),
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

        public static List<Producto> DetalleCompra(int idCompra)
        {
            List<Producto> detalleCompra = [];

            string query = """
                SELECT p.id_producto, p.nombre producto, m.id_marca, m.nombre marca,
                dc.precio_compra, dc.precio_venta, dc.cantidad 
                FROM detalle_compra dc 
                INNER JOIN producto p ON dc.id_producto = p.id_producto
                INNER JOIN marca m ON p.id_marca = m.id_marca 
                WHERE dc.id_compra = @IdCompra;
                """;

            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand command = new(query, conn);
                command.Parameters.AddWithValue("@idCompra", idCompra);

                using NpgsqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Producto producto = new()
                    {
                        IdProducto = reader.GetInt32("id_producto"),
                        Marca = new()
                        {
                            IdMarca = reader.GetInt32("id_marca"),
                            Nombre = reader.GetString("marca")
                        },
                        Nombre = reader.GetString("producto"),
                        PrecioCompra = reader.GetDecimal("precio_compra"),
                        PrecioVenta = reader.GetDecimal("precio_venta"),
                        Stock = reader.GetInt32("cantidad"),
                        StockMinimo = 0,
                    };

                    detalleCompra.Add(producto);
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
