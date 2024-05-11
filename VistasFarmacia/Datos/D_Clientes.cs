using Npgsql;
using System.Data;

namespace VistasFarmacia.Datos
{
    internal class D_Clientes
    {
        // Instanciar conexion
        private ConexionDB conexion = new ConexionDB();

        public DataTable Listar()
        {
            NpgsqlDataReader leer; // Para leer filas de X tabla
            DataTable tabla = new DataTable(); // Para almacenar el resultado
            NpgsqlCommand comando = new NpgsqlCommand(); // Ejecutar comandos SQL
            tabla.Clear(); // Para evitar que se llene con registros duplicados

            try
            {
                comando.CommandText = "select * from cliente";
                comando.Connection = conexion.AbrirConexion();
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al hacer la consulta en la base de datos. " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return null;
        }

    }
}
