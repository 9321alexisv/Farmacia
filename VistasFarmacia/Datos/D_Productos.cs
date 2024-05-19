
using Npgsql;
using System.Data;
using VistasFarmacia.Datos;
using VistasFarmacia.Entidad;

namespace Farmacia.Datos
{
    public class D_Productos
    {
        public static DataTable Listar()
        {
            DataTable tabla = new();
            string query = "SELECT p.id_producto codigo, pro.proveedor, p.nombre producto, " +
                "p.precio_compra, p.precio_venta, p.stock FROM producto p " +
                "INNER JOIN proveedor pro ON p.id_proveedor = pro.id_proveedor " +
                "WHERE p.estado = true;";

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
            string query = "SELECT * FROM producto WHERE id_producto = @idProducto";

            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand comando = new(query, conn);
                comando.Parameters.AddWithValue("@idProducto", idProducto);

                using NpgsqlDataReader leer = comando.ExecuteReader();

                if (leer.Read())
                {
                    producto = new()
                    {
                        IdProducto = Convert.ToInt32(leer["id_producto"]),
                        ObjProveedor = new Proveedor
                        {
                            IdProveedor = Convert.ToInt32(leer["id_proveedor"])
                        },
                        Nombre = Convert.ToString(leer["nombre"]) ?? "",
                        PrecioCompra = Convert.ToDecimal(leer["precio_compra"]),
                        PrecioVenta = Convert.ToDecimal(leer["precio_venta"]),
                        Stock = Convert.ToInt32(leer["stock"])
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

        public static DataTable BuscarPorNombre(string query)
        {
            DataTable tabla = new();
            string sentencia = "SELECT p.id_producto codigo, pro.proveedor, p.nombre producto, " +
                "p.precio_compra, p.precio_venta, p.stock FROM producto p " +
                "INNER JOIN proveedor pro ON p.id_proveedor = pro.id_proveedor " +
                $"WHERE UPPER(p.nombre) LIKE '%{query.ToUpper()}%' AND p.estado = true;";

            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand comando = new(sentencia, conn);
                using NpgsqlDataReader leer = comando.ExecuteReader();
                tabla.Load(leer);
                
                return tabla;
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al buscar los regisros en la base de datos.", ex);
            }
        }

        public static void Crear(int idProveedor, string nombre, decimal precioCompra, decimal precioVenta, int stock)
        {
            string query = "INSERT INTO producto (id_proveedor, nombre, precio_compra, precio_venta, stock) VALUES (@idProveedor, @nombre, @precioCompra, @precioVenta, @stock)";

            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand comando = new(query, conn);

                comando.Parameters.AddWithValue("@idProveedor", idProveedor);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@precioCompra", precioCompra);
                comando.Parameters.AddWithValue("@precioVenta", precioVenta);
                comando.Parameters.AddWithValue("@stock", stock);

                comando.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al crear el registro en la base de datos.", ex);
            }
        }

        public static void Editar(int idProducto, int idProveedor, string nombre, decimal precioCompra, decimal precioVenta, int stock)
        {
            string query = "UPDATE producto SET id_proveedor = @idProveedor, nombre = @nombre, precio_compra = @precioCompra, precio_venta = @precioVenta, stock = @stock WHERE id_producto = @idProducto";

            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand comando = new(query, conn);

                comando.Parameters.AddWithValue("@idProducto", idProducto);
                comando.Parameters.AddWithValue("@idProveedor", idProveedor);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@precioCompra", precioCompra);
                comando.Parameters.AddWithValue("@precioVenta", precioVenta);
                comando.Parameters.AddWithValue("@stock", stock);

                comando.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al actualizar el registro en la base de datos." + ex);
            }
        }

        // Eliminado logico
        public static bool Eliminar(int id)
        {
            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand comando = new("UPDATE producto SET estado = false WHERE id_producto = @id", conn);
                comando.Parameters.AddWithValue("@id", id);
                int filasAfectadas = comando.ExecuteNonQuery();
                
                return filasAfectadas > 0; // True si se actualizó al menos un registro
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al eliminar (logico) el registro de la base de datos.", ex);
            }
        }

    }
}
