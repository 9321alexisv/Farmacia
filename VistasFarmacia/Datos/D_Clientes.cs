
using Npgsql;
using System.Data;

namespace VistasFarmacia.Datos
{
    internal class D_Clientes
    {
        public static DataTable Listar()
        {
            DataTable tabla = new();

            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand comando = new("select * from cliente", conn);
                using NpgsqlDataReader leer = comando.ExecuteReader();
                tabla.Load(leer);
                
                return tabla;
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al obtener todos los registros de la base de datos.", ex);
            }
        }

        public static void Insertar(string nit, string nombre, string telefono)
        {
            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                
                using NpgsqlCommand cmd = new("INSERT INTO cliente (nit, nombre, telefono) VALUES (@nit, @nombre, @telefono)", conn);
                cmd.Parameters.AddWithValue("@nit", nit);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@telefono", telefono);

                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al crear el registro en la base de datos.", ex);
            }
        }

        public static void Editar(int idCliente, string nit, string nombre, string telefono)
        {

            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand cmd = new("UPDATE cliente SET nit = @nit, nombre = @nombre, telefono = @telefono WHERE id_cliente = @idCliente", conn);
                
                cmd.Parameters.AddWithValue("@nit", nit);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@idCliente", idCliente);

                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al actualizar el registro en la base de datos.", ex);
            }
        }

        // Eliminado logico
        public static void Eliminar(int idCliente)
        {
            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand cmd = new("UPDATE cliente SET estado = false WHERE id_cliente = @idCliente", conn);
                cmd.Parameters.AddWithValue("@idCliente", idCliente);

                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                throw new Exception("Error al eliminar (logico) el reistro de la base de datos.", ex);
            }
        }
    }
}
