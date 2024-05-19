
using Npgsql;
using System.Data;

namespace VistasFarmacia.Datos
{
    public class ConexionDB
    {
        private readonly string servidor = "localhost";
        private readonly string baseDatos = "farmacia_candelaria_dev";
        private readonly int puerto = 5433;
        private readonly string usuario = "postgres";
        private readonly string contrasena = "";

        private readonly NpgsqlConnection Conexion;

        public ConexionDB()
        {
            string cadenaConexion = $"Server={servidor};Port={puerto};User Id={usuario};Password={contrasena};Database={baseDatos};";

            Conexion = new NpgsqlConnection(cadenaConexion);
        }

        public NpgsqlConnection? AbrirConexion()
        {
            try
            {
                if (Conexion.State == ConnectionState.Closed) Conexion.Open();
                return Conexion;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al conectarse a la base de datos.", "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // No es necesario llamar el metodo si se utiliza USING para crear la instancia de la conexion
        public void CerrarConexion()
        {
            //if (Conexion != null && Conexion.State == ConnectionState.Open) Conexion.Dispose();
        }
    }
}
