using Npgsql;
using System.Data;
using VistasFarmacia.Datos;

namespace Farmacia.Datos
{
    public class D_Proveedores
    {
        public DataTable Listar()
        {
            ConexionDB conexion = new();
            NpgsqlDataReader leer;
            DataTable tabla = new();

            try
            {
                NpgsqlCommand comando = new("select * from proveedor where estado = true", conexion.AbrirConexion());
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

        public void Insertar(string nit, string proveedor, string telefono, string representante)
        {
            ConexionDB conexion = new();

            try
            {
                using NpgsqlConnection conn = conexion.AbrirConexion();
                using NpgsqlCommand cmd = new("INSERT INTO proveedor (nit, proveedor, telefono, representante) VALUES (@nit, @proveedor, @telefono, @representante)", conn);
                cmd.Parameters.AddWithValue("@nit", nit);
                cmd.Parameters.AddWithValue("@proveedor", proveedor);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@representante", representante);

                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                throw new Exception("Error al insertar el registro en la base de datos.", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public void Actualizar(int idProveedor, string nit, string proveedor, string telefono, string representante)
        {
            ConexionDB conexion = new();

            try
            {
                using NpgsqlConnection conn = conexion.AbrirConexion();
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
                throw new Exception("Error al actualizar el registro en la base de datos.", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        // Eliminado logico
        public bool Eliminar(int id)
        {
            ConexionDB conexion = new();
            NpgsqlCommand comando;

            try
            {
                comando = new NpgsqlCommand("UPDATE proveedor SET estado = false WHERE id_proveedor = @id", conexion.AbrirConexion());
                comando.Parameters.AddWithValue("@id", id);

                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas > 0; // True si se actualizó al menos un registro
            }
            catch (NpgsqlException ex)
            {
                throw new Exception("Error al actualizar el registro en la base de datos.", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }
}
