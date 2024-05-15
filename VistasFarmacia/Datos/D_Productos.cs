
using Npgsql;
using System.Data;
using VistasFarmacia.Datos;
using VistasFarmacia.Entidad;

namespace Farmacia.Datos
{
    public class D_Productos
    {
        public DataTable Listar()
        {
            ConexionDB conexion = new ConexionDB();
            NpgsqlDataReader leer;
            DataTable tabla = new DataTable();

            try
            {
                NpgsqlCommand comando = new NpgsqlCommand("select * from producto", conexion.AbrirConexion());
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                return tabla;
            }
            catch (NpgsqlException ex)
            {
                throw new Exception("Error al hacer la consulta en la base de datos.", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public Producto BuscarPorId(int idProducto)
        {
            ConexionDB conexion = new ConexionDB();
            Producto producto = null;

            try
            {
                string query = "SELECT * FROM producto WHERE id_producto = @idProducto";
                NpgsqlCommand comando = new NpgsqlCommand(query, conexion.AbrirConexion());
                comando.Parameters.AddWithValue("@idProducto", idProducto);

                NpgsqlDataReader leer = comando.ExecuteReader();

                if (leer.Read())
                {
                    producto = new Producto
                    {
                        IdProducto = Convert.ToInt32(leer["id_producto"]),
                        ObjProveedor = new Proveedor
                        {
                            IdProveedor = Convert.ToInt32(leer["id_proveedor"])
                        },
                        Nombre = Convert.ToString(leer["nombre"]),
                        PrecioCompra = Convert.ToDecimal(leer["precio_compra"]),
                        PrecioVenta = Convert.ToDecimal(leer["precio_venta"]),
                        Stock = Convert.ToInt32(leer["stock"])
                    };
                }
            }
            catch (NpgsqlException ex)
            {
                throw new Exception("Error al buscar el producto por ID en la base de datos.", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return producto;
        }

        public DataTable BuscarPorNombre(string query)
        {
            ConexionDB conexion = new();
            NpgsqlDataReader leer;
            DataTable tabla = new();

            try
            {
                NpgsqlCommand comando = new(
                    $"select * from producto where nombre LIKE '%{query}%';", 
                    conexion.AbrirConexion()
                );
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                return tabla;
            }
            catch (NpgsqlException ex)
            {
                throw new Exception("Error al hacer la consulta en la base de datos.", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public void Crear(int idProveedor, string nombre, decimal precioCompra, decimal precioVenta, int stock)
        {
            ConexionDB conexion = new ConexionDB();

            try
            {
                string query = "INSERT INTO producto (id_proveedor, nombre, precio_compra, precio_venta, stock) VALUES (@idProveedor, @nombre, @precioCompra, @precioVenta, @stock)";

                NpgsqlCommand comando = new NpgsqlCommand(query, conexion.AbrirConexion());

                comando.Parameters.AddWithValue("@idProveedor", idProveedor);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@precioCompra", precioCompra);
                comando.Parameters.AddWithValue("@precioVenta", precioVenta);
                comando.Parameters.AddWithValue("@stock", stock);

                comando.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                throw new Exception("Error al guardar el registro en la base de datos.", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public void Editar(int idProducto, int idProveedor, string nombre, decimal precioCompra, decimal precioVenta, int stock)
        {
            ConexionDB conexion = new ConexionDB();

            try
            {
                string query = "UPDATE producto SET id_proveedor = @idProveedor, nombre = @nombre, precio_compra = @precioCompra, precio_venta = @precioVenta, stock = @stock WHERE id_producto = @idProducto";

                NpgsqlCommand comando = new NpgsqlCommand(query, conexion.AbrirConexion());

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
                throw new Exception("Error al actualizar el registro en la base de datos." + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        // Eliminado logico
        public bool Eliminar(int id)
        {
            ConexionDB conexion = new ConexionDB();
            NpgsqlCommand comando;

            try
            {
                comando = new NpgsqlCommand("UPDATE producto SET estado = false WHERE id_producto = @id", conexion.AbrirConexion());
                comando.Parameters.AddWithValue("@id", id);

                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas > 0; // True si se actualizó al menos un registro
            }
            catch (NpgsqlException ex)
            {
                throw new Exception("Error al actualizar el producto en la base de datos.", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

    }
}
