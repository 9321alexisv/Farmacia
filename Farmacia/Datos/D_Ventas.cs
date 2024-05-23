
using Farmacia.Entidad;
using Npgsql;
using System.Data;

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
        public static List<Venta> VentasPorFechas(DateTime? fechaInicio, DateTime? fechaFin)
        {
            List<Venta> ventas = [];
            string query = """
                    SELECT
                    v.id_venta,
                    v.id_cliente,
                    c.nit nit_cliente,
                    c.nombre cliente,
                    c.telefono telefono_cliente,
                    v.fecha,
                    dv.id_producto,
                    p.nombre producto,
                    m.id_marca,
                    m.nombre marca,
                    dv.precio_compra,
                    dv.precio_venta,
                    dv.cantidad 
                FROM
                    venta v
                    JOIN cliente c ON v.id_cliente = c.id_cliente
                    LEFT JOIN detalle_venta dv ON v.id_venta = dv.id_venta
                    LEFT JOIN producto p ON dv.id_producto = p.id_producto 
                    LEFT JOIN marca m ON p.id_marca = m.id_marca
                WHERE
                    v.fecha BETWEEN @fechaInicio AND @fechaFin
                ORDER BY
                    v.id_venta DESC, dv.id_producto;
                """;

            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio.HasValue ? fechaInicio.Value : DateTime.MinValue.ToString());
                cmd.Parameters.AddWithValue("@fechaFin", fechaFin.HasValue ? fechaFin.Value : DateTime.Now.Date.ToString());

                using NpgsqlDataReader datos = cmd.ExecuteReader();

                Venta? ventaActual = null;

                while (datos.Read())
                {
                    int idVenta = datos.GetFieldValue<int>("id_venta");

                    if (ventaActual == null || ventaActual.IdVenta != idVenta)
                    {
                        ventaActual = new Venta
                        {
                            IdVenta = idVenta,
                            Cliente = new Cliente
                            {
                                IdCliente = datos.GetFieldValue<int>("id_cliente"),
                                Nit = datos.GetFieldValue<string>("nit_cliente"),
                                Nombre = datos.GetFieldValue<string>("cliente"),
                                Telefono = datos.GetFieldValue<string>("telefono_cliente")
                            },
                            Fecha = datos.GetFieldValue<DateTime>("fecha"),
                            Productos = []
                        };
                        ventas.Add(ventaActual);
                    }

                    if (!datos.IsDBNull(datos.GetOrdinal("id_producto")))
                    {
                        ventaActual.Productos!.Add(new Producto
                        {
                            IdProducto = datos.GetFieldValue<int>("id_producto"),
                            Nombre = datos.GetString("producto"),
                            PrecioCompra = datos.GetDecimal("precio_compra"),
                            PrecioVenta = datos.GetDecimal("precio_venta"),
                            Stock = datos.GetFieldValue<int>("cantidad"),
                            StockMinimo = 0,
                            Marca = new()
                            {
                                IdMarca = datos.GetInt32("id_marca"),
                                Nombre = datos.GetString("marca"),
                            }
                        });
                    }
                }

                return ventas;
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al obtener ventas por fechas.", ex);
            }
        }

        // ============================================================================================
        // ELIMINAR VENTA (FISICO) ====================================================================
        // ============================================================================================
        public static void Eliminar(int idVenta)
        {
            string query = """
                BEGIN;
                    -- Actualizar stock de productos
                    WITH productos_venta AS (
                        SELECT id_producto, SUM(cantidad) AS cantidad_total
                        FROM detalle_venta
                        WHERE id_venta = @venta_eliminar
                        GROUP BY id_producto
                    )
                    UPDATE producto p
                    SET stock = p.stock + pv.cantidad_total
                    FROM productos_venta pv
                    WHERE p.id_producto = pv.id_producto;

                    DELETE FROM detalle_venta WHERE id_venta = @venta_eliminar;
                
                    DELETE FROM venta WHERE id_venta = @venta_eliminar;
                COMMIT;
                """;

            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand command = new(query, conn);
                command.Parameters.AddWithValue("@venta_eliminar", idVenta);
                command.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al eliminar la 'venta'", ex);
            }
        }
    }
}
