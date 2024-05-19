﻿
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

        private NpgsqlConnection Conexion;

        public ConexionDB()
        {
            string cadenaConexion = $"Server={servidor};Port={puerto};User Id={usuario};Password={contrasena};Database={baseDatos};";

            Conexion = new NpgsqlConnection(cadenaConexion);
        }

        public NpgsqlConnection AbrirConexion()
        {
            try
            {
                if (Conexion.State == ConnectionState.Closed) Conexion.Open();
                return Conexion;
            } catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse a la base de datos." + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        public NpgsqlConnection CerrarConexion()
        {
            //if (Conexion != null && Conexion.State == ConnectionState.Open) Conexion.Close();

            if (Conexion.State == ConnectionState.Open) Conexion.Close();
            return Conexion;
        }
    }
}
