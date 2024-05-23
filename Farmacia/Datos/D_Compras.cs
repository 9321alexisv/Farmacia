
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
                using NpgsqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@id_compra", idCompra);
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
                ORDER BY c.id_compra DESC;
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

        // ============================================================================================
        // ELIMINAR COMPRA (FISICO) ===================================================================
        // ============================================================================================
        public static void Eliminar(int idCompra)
        {
            string query = """
                BEGIN;
                    -- Actualizar stock de productos
                    WITH productos_compra AS (
                        SELECT id_producto, SUM(cantidad) AS cantidad_total
                        FROM detalle_compra
                        WHERE id_compra = @compra_eliminar
                        GROUP BY id_producto
                    )
                    UPDATE producto p
                    SET stock = p.stock - pc.cantidad_total
                    FROM productos_compra pc
                    WHERE p.id_producto = pc.id_producto;

                    DELETE FROM detalle_compra WHERE id_compra = @compra_eliminar;
                
                    DELETE FROM compra WHERE id_compra = @compra_eliminar;
                COMMIT;
                """;

            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand command = new(query, conn);
                command.Parameters.AddWithValue("@compra_eliminar", idCompra);
                command.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al eliminar la 'compra'", ex);
            }
        }

    }
}
