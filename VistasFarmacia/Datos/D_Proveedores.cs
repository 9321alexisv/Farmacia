using Npgsql;
using System.Data;
using VistasFarmacia.Datos;

namespace Farmacia.Datos
{
    public class D_Proveedores
    {
        public DataTable Listar()
        {
            ConexionDB conexion = new ConexionDB();
            NpgsqlDataReader leer;
            DataTable tabla = new DataTable();

            try
            {
                NpgsqlCommand comando = new NpgsqlCommand("select * from proveedor", conexion.AbrirConexion());
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
            ConexionDB conexion = new ConexionDB();

            try
            {
                using (NpgsqlConnection conn = conexion.AbrirConexion())
                using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO proveedor (nit, proveedor, telefono, representante) VALUES (@nit, @proveedor, @telefono, @representante)", conn))
                {
                    cmd.Parameters.AddWithValue("@nit", nit);
                    cmd.Parameters.AddWithValue("@proveedor", proveedor);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@representante", representante);

                    cmd.ExecuteNonQuery();
                }
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
    }
}
