
using Npgsql;
using System.Data;

namespace Farmacia.Datos
{
    public class D_Proveedores
    {
        public static DataTable Listar()
        {
            DataTable tabla = new();

            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand comando = new("select * from proveedor where estado = true", conn);
                using NpgsqlDataReader leer = comando.ExecuteReader();
                tabla.Load(leer);
                
                return tabla;
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al obtener todos los registros de la base de datos.", ex);
            }
        }

        public static void Insertar(string nit, string proveedor, string telefono, string representante)
        {

            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand cmd = new("INSERT INTO proveedor (nit, proveedor, telefono, representante) VALUES (@nit, @proveedor, @telefono, @representante)", conn);
                
                cmd.Parameters.AddWithValue("@nit", nit);
                cmd.Parameters.AddWithValue("@proveedor", proveedor);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@representante", representante);

                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al crear el registro en la base de datos.", ex);
            }
        }

        public void Actualizar(int idProveedor, string nit, string proveedor, string telefono, string representante)
        {

            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand cmd = new("UPDATE proveedor SET nit = @nit, proveedor = @proveedor, telefono = @telefono, representante = @representante WHERE id_proveedor = @idProveedor", conn);

                cmd.Parameters.AddWithValue("@nit", nit);
                cmd.Parameters.AddWithValue("@proveedor", proveedor);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@representante", representante);
                cmd.Parameters.AddWithValue("@idProveedor", idProveedor);

                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al actualizar el registro en la base de datos.", ex);
            }
        }

        // Eliminado logico
        public static bool Eliminar(int id)
        {
            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand comando = new("UPDATE proveedor SET estado = false WHERE id_proveedor = @id", conn);
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
