
using Npgsql;
using System.Data;

namespace VistasFarmacia.Datos
{
    public class ConexionDB
    {
        private NpgsqlConnection Conexion = new NpgsqlConnection("Server=localhost;Port=5433;User Id=postgres;Password=;Database=farmacia_candelaria_dev;");

        public NpgsqlConnection AbrirConexion()
        {
            try
            {
                if (Conexion.State == ConnectionState.Closed) Conexion.Open();
                return Conexion;
            } catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse a la base de datos.", "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        public NpgsqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open) Conexion.Close();
            return Conexion;
        }
    }
}
