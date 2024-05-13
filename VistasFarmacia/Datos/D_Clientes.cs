﻿using Npgsql;
using System.Data;

namespace VistasFarmacia.Datos
{
    internal class D_Clientes
    {

        public DataTable Listar()
        {
            ConexionDB conexion = new ConexionDB();
            NpgsqlDataReader leer;
            DataTable tabla = new DataTable();

            try
            {
                NpgsqlCommand comando = new NpgsqlCommand("select * from cliente", conexion.AbrirConexion());
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

        public void Insertar(string nit, string nombre, string telefono)
        {
            ConexionDB conexion = new ConexionDB();

            try
            {
                using (NpgsqlConnection conn = conexion.AbrirConexion())
                using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO cliente (nit, nombre, telefono) VALUES (@nit, @nombre, @telefono)", conn))
                {
                    cmd.Parameters.AddWithValue("@nit", nit);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@telefono", telefono);

                    cmd.ExecuteNonQuery();
                }
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

    }
}