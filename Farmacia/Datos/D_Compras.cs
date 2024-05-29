
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

        public static void InsertarDetalleCompra(int idCompra, DataGridView dgvProductos, bool promedio = false)
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

                if (promedio)
                {
                    ActualizarProductosConPromedio(dgvProductos);
                } else
                {
                    ActualizarStockProductos(dgvProductos);
                }

            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al insertar en la tabla 'detalle_compra'." + ex);
            }
        }

        //public static void ActualizarStockProductosOld(DataGridView dgvProductos)
        //{
        //    try
        //    {
        //        ConexionDB conexion = new();
        //        using NpgsqlConnection conn = conexion.AbrirConexion()!;

        //        foreach (DataGridViewRow row in dgvProductos.Rows)
        //        {
        //            int idProducto = Convert.ToInt32(row.Cells["IdProducto"].Value);
        //            int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

        //            string query = "UPDATE producto SET stock = stock + @cantidad WHERE id_producto = @idProducto";

        //            using NpgsqlCommand cmd = new(query, conn);
        //            cmd.Parameters.AddWithValue("@cantidad", cantidad);
        //            cmd.Parameters.AddWithValue("@idProducto", idProducto);
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //    catch (NpgsqlException ex)
        //    {
        //        throw new NpgsqlException("Error al actualizar el stock de los productos: " + ex.Message);
        //    }
        //}

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
                    decimal precioCompra = Convert.ToDecimal(row.Cells["PrecioCompra"].Value);
                    decimal precioVenta = Convert.ToDecimal(row.Cells["PrecioVenta"].Value);

                    string query = "UPDATE producto SET stock = stock + @cantidad, precio_compra = @precioCompra, precio_venta = @precioVenta WHERE id_producto = @idProducto";

                    using NpgsqlCommand cmd = new(query, conn);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@precioCompra", precioCompra);
                    cmd.Parameters.AddWithValue("@precioVenta", precioVenta);
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al actualizar el stock y precios de los productos: " + ex.Message);
            }
        }

        public static void ActualizarProductosConPromedio(DataGridView dgvProductos)
        {
            string query = """
                UPDATE producto
                SET stock = stock + @cantidad,
                precio_compra = (SELECT (precio_compra + @precioCompra) / 2 FROM producto WHERE id_producto = @idProducto),
                precio_venta = (SELECT (precio_venta + @precioVenta) / 2 FROM producto WHERE id_producto = @idProducto)
                WHERE id_producto = @idProducto;
                """;
            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;

                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    int idProducto = Convert.ToInt32(row.Cells["IdProducto"].Value);
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    decimal precioCompra = Convert.ToDecimal(row.Cells["PrecioCompra"].Value);
                    decimal precioVenta = Convert.ToDecimal(row.Cells["PrecioVenta"].Value);

                    using NpgsqlCommand cmdActualizar = new(query, conn);
                    cmdActualizar.Parameters.AddWithValue("@cantidad", cantidad);
                    cmdActualizar.Parameters.AddWithValue("@precioCompra", precioCompra);
                    cmdActualizar.Parameters.AddWithValue("@precioVenta", precioVenta);
                    cmdActualizar.Parameters.AddWithValue("@idProducto", idProducto);

                    cmdActualizar.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al actualizar los productos con promedio: ", ex);
            }
        }

        // ============================================================================================
        // OBTENER COMPRAS ==================================================================
        // ============================================================================================

        public static List<Compra> ComprasPorFechas(DateTime? fechaInicio, DateTime? fechaFin)
        {
            List<Compra> compras = [];
            string query = """
                SELECT
                    c.id_compra,
                    c.id_proveedor,
                    pro.nit nit_proveedor,
                    pro.nombre proveedor,
                    pro.telefono telefono_proveedor,
                    c.fecha,
                    dc.id_producto,
                    p.nombre producto,
                    m.id_marca,
                    m.nombre marca,
                    dc.precio_compra,
                    dc.precio_venta,
                    dc.cantidad 
                FROM
                    compra c
                    JOIN proveedor pro ON c.id_proveedor = pro.id_proveedor
                    LEFT JOIN detalle_compra dc ON c.id_compra = dc.id_compra
                    LEFT JOIN producto p ON dc.id_producto = p.id_producto 
                    LEFT JOIN marca m ON p.id_marca = m.id_marca
                WHERE
                    c.fecha BETWEEN @fechaInicio AND @fechaFin
                ORDER BY
                    c.id_compra DESC, dc.id_producto;
                """;

            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio.HasValue ? fechaInicio.Value : DateTime.MinValue.ToString());
                cmd.Parameters.AddWithValue("@fechaFin", fechaFin.HasValue ? fechaFin.Value : DateTime.Now.Date.ToString());

                using NpgsqlDataReader datos = cmd.ExecuteReader();

                Compra? compraActual = null;

                while (datos.Read())
                {
                    int idCompra = datos.GetFieldValue<int>("id_compra");

                    if (compraActual == null || compraActual.IdCompra != idCompra)
                    {
                        compraActual = new Compra
                        {
                            IdCompra = idCompra,
                            Proveedor = new Proveedor
                            {
                                IdProveedor = datos.GetFieldValue<int>("id_proveedor"),
                                Nit = datos.GetFieldValue<string>("nit_proveedor"),
                                Nombre = datos.GetFieldValue<string>("proveedor"),
                                Telefono = datos.GetFieldValue<string>("telefono_proveedor")
                            },
                            Fecha = datos.GetFieldValue<DateTime>("fecha"),
                            Productos = []
                        };
                        compras.Add(compraActual);
                    }

                    if (!datos.IsDBNull(datos.GetOrdinal("id_producto")))
                    {
                        compraActual.Productos!.Add(new Producto
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

                return compras;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw new NpgsqlException("Error al obtener compras por fechas.", ex);
            }
        }

        public static Compra? CompraPorId(int idCompra)
        {
            Compra? compra = null;
            string query = """
                SELECT
                    c.id_compra,
                    c.id_proveedor,
                    pro.nit nit_proveedor,
                    pro.nombre proveedor,
                    pro.telefono telefono_proveedor,
                    c.fecha,
                    dc.id_producto,
                    p.nombre producto,
                    m.id_marca,
                    m.nombre marca,
                    dc.precio_compra,
                    dc.precio_venta,
                    dc.cantidad 
                FROM
                    compra c
                    JOIN proveedor pro ON c.id_proveedor = pro.id_proveedor
                    LEFT JOIN detalle_compra dc ON c.id_compra = dc.id_compra
                    LEFT JOIN producto p ON dc.id_producto = p.id_producto 
                    LEFT JOIN marca m ON p.id_marca = m.id_marca
                WHERE
                    c.id_compra = @idCompra 
                ORDER BY
                    c.id_compra DESC, dc.id_producto;
                """;

            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@idCompra", idCompra);

                using NpgsqlDataReader datos = cmd.ExecuteReader();

                Compra? compraActual = null;

                while (datos.Read())
                {
                    if (compraActual == null)
                    {
                        compraActual = new Compra
                        {
                            IdCompra = datos.GetFieldValue<int>("id_compra"),
                            Proveedor = new Proveedor
                            {
                                IdProveedor = datos.GetFieldValue<int>("id_proveedor"),
                                Nit = datos.GetFieldValue<string>("nit_proveedor"),
                                Nombre = datos.GetFieldValue<string>("proveedor"),
                                Telefono = datos.GetFieldValue<string>("telefono_proveedor")
                            },
                            Fecha = datos.GetFieldValue<DateTime>("fecha"),
                            Productos = []
                        };
                        compra = compraActual;
                    }

                    if (!datos.IsDBNull(datos.GetOrdinal("id_producto")))
                    {
                        compraActual.Productos!.Add(new Producto
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

                return compra;
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al obtener la compra por ID.", ex);
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
