
using Npgsql;
using System.Data;

namespace VistasFarmacia.Datos
{
    internal class D_Clientes
    {

        public static DataTable Listar()
        {
            ConexionDB conexion = new();
            NpgsqlDataReader leer;
            DataTable tabla = new();

            try
            {
                NpgsqlCommand comando = new("select * from cliente", conexion.AbrirConexion());
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

        public static void Insertar(string nit, string nombre, string telefono)
        {
            ConexionDB conexion = new();

            try
            {
                using NpgsqlConnection conn = conexion.AbrirConexion();
                using NpgsqlCommand cmd = new("INSERT INTO cliente (nit, nombre, telefono) VALUES (@nit, @nombre, @telefono)", conn);
                cmd.Parameters.AddWithValue("@nit", nit);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@telefono", telefono);

                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                throw new Exception("Error al insertar el cliente en la base de datos.", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public void Editar(int idCliente, string nit, string nombre, string telefono)
        {
            ConexionDB conexion = new();

            try
            {
                using NpgsqlConnection conn = conexion.AbrirConexion();
                using NpgsqlCommand cmd = new("UPDATE cliente SET nit = @nit, nombre = @nombre, telefono = @telefono WHERE id_cliente = @idCliente", conn);
                cmd.Parameters.AddWithValue("@nit", nit);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@idCliente", idCliente);

                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                throw new Exception("Error al actualizar el cliente en la base de datos.", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        // Eliminado logico
        public void Eliminar(int idCliente)
        {
            ConexionDB conexion = new();

            try
            {
                using NpgsqlConnection conn = conexion.AbrirConexion();
                using NpgsqlCommand cmd = new("UPDATE cliente SET estado = false WHERE id_cliente = @idCliente", conn);
                cmd.Parameters.AddWithValue("@idCliente", idCliente);

                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                throw new Exception("Error al borrar el cliente en la base de datos.", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }
}
