
using Farmacia.Entidad;
using Npgsql;
using System.Data;

namespace Farmacia.Datos
{
    public class D_Productos
    {
        public static DataTable Listar()
        {
            DataTable tabla = new();
            string query = """
                SELECT p.id_producto, m.id_marca, m.nombre marca, p.nombre producto, p.precio_compra, 
                p.precio_venta, p.stock, p.stock_minimo, p.estado
                FROM producto p
                INNER JOIN marca m ON p.id_marca = m.id_marca
                WHERE p.estado = TRUE;
                """;

            Console.WriteLine(query);

            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand comando = new(query, conn);
                using NpgsqlDataReader leer = comando.ExecuteReader();
                tabla.Load(leer);

                return tabla;
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al obtener todos los registros de la base de datos.", ex);
            }
        }

        public static Producto? BuscarPorId(int idProducto)
        {
            Producto producto;
            string query = """
                SELECT p.id_producto, m.id_marca, m.nombre marca, p.nombre producto, p.precio_compra, 
                p.precio_venta, p.stock, p.stock_minimo, p.estado
                FROM producto p
                INNER JOIN marca m ON p.id_marca = m.id_marca
                WHERE p.estado = TRUE AND id_producto = @id_producto;
                """;

            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand comando = new(query, conn);
                comando.Parameters.AddWithValue("@id_producto", idProducto);

                using NpgsqlDataReader datos = comando.ExecuteReader();

                if (datos.Read())
                {
                    producto = new()
                    {

                        IdProducto = Convert.ToInt32(datos["id_producto"]),
                        Marca = new()
                        {
                            IdMarca = datos.GetFieldValue<int>("id_marca"),
                            Nombre = datos.GetFieldValue<string>("marca"),
                        },
                        Nombre = datos.GetFieldValue<string>("producto"),
                        PrecioCompra = datos.GetFieldValue<decimal>("precio_compra"),
                        PrecioVenta = datos.GetFieldValue<decimal>("precio_venta"),
                        Stock = datos.GetFieldValue<int>("stock"),
                        StockMinimo = datos.GetFieldValue<int>("stock_minimo")
                    };
                    
                    return producto;
                }
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al buscar el registro por ID en la base de datos.", ex);
            }

            return null;
        }

        public static DataTable BuscarPorIdNombreMarca(string termino)
        {
            DataTable tabla = new();
            bool isNumeric = int.TryParse(termino, out int productId);
            string query = @"
                SELECT p.id_producto, m.id_marca, m.nombre AS marca, p.nombre AS producto, 
                       p.precio_compra, p.precio_venta, p.stock, p.stock_minimo, p.estado
                FROM producto p
                INNER JOIN marca m ON p.id_marca = m.id_marca
                WHERE p.estado = TRUE
                AND (
                    (@IsNumeric AND p.id_producto = @ProductId)
                    OR (p.nombre ILIKE '%' || @InputQuery || '%')
                    OR (m.nombre ILIKE '%' || @InputQuery || '%')
                );";

            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@IsNumeric", isNumeric);
                cmd.Parameters.AddWithValue("@ProductId", productId);
                cmd.Parameters.AddWithValue("@InputQuery", termino.ToLower());
                using NpgsqlDataReader leer = cmd.ExecuteReader();
                tabla.Load(leer);
                
                return tabla;
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al buscar los regisros en la base de datos.", ex);
            }
        }

        public static bool Crear(Producto producto)
        {
            string query = "INSERT INTO producto (id_marca, nombre, precio_compra, precio_venta, stock, stock_minimo) VALUES (@id_marca, @nombre, @precio_compra, @precio_venta, @stock, @stock_minimo)";

            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@id_marca", producto.Marca.IdMarca);
                cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@precio_compra", producto.PrecioCompra);
                cmd.Parameters.AddWithValue("@precio_venta", producto.PrecioVenta);
                cmd.Parameters.AddWithValue("@stock", producto.Stock);
                cmd.Parameters.AddWithValue("@stock_minimo", producto.StockMinimo);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas == 1;
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al crear el registro en la base de datos.", ex);
            }
        }

        public static bool Editar(Producto producto)
        {
            string query = "UPDATE producto SET id_marca = @id_marca, nombre = @nombre, precio_compra = @precio_compra, precio_venta = @precio_venta, stock = @stock, stock_minimo = @stock_minimo WHERE id_producto = @id_producto";

            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@id_producto", producto.IdProducto!);
                cmd.Parameters.AddWithValue("@id_marca", producto.Marca.IdMarca);
                cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@precio_compra", producto.PrecioCompra);
                cmd.Parameters.AddWithValue("@precio_venta", producto.PrecioVenta);
                cmd.Parameters.AddWithValue("@stock", producto.Stock);
                cmd.Parameters.AddWithValue("@stock_minimo", producto.StockMinimo);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas == 1;
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al actualizar el registro en la base de datos." + ex);
            }
        }

        // Eliminado logico
        public static bool Eliminar(int idProducto)
        {
            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand cmd = new("UPDATE producto SET estado = false WHERE id_producto = @id", conn);
                cmd.Parameters.AddWithValue("@id", idProducto);
                
                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas == 1;
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al eliminar (logico) el registro de la base de datos.", ex);
            }
        }

    }
}
