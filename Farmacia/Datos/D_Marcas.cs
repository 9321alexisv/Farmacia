
using Farmacia.Entidad;
using Npgsql;

namespace Farmacia.Datos
{
    internal class D_Marcas
    {
        public static List<Marca> Listar()
        {
            List<Marca> marcas = [];

            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand comando = new("select * from marca;", conn);
                using NpgsqlDataReader leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    Marca marca = new()
                    {
                        IdMarca = leer.GetInt32(leer.GetOrdinal("id_marca")),
                        Nombre = leer.GetString(leer.GetOrdinal("nombre")),
                        Telefono = leer.GetString(leer.GetOrdinal("telefono")),
                        Representante = leer.GetString(leer.GetOrdinal("representante")),
                        Estado = leer.GetBoolean(leer.GetOrdinal("estado")),
                    };

                    marcas.Add(marca);
                }

                return marcas;
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al obtener todos los registros de la base de datos.", ex);
            }
        }

        public static bool Insertar(Marca marca)
        {
            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand cmd = new("INSERT INTO marca (nombre, telefono, representante) VALUES (@nombre, @telefono, @representante)", conn);

                cmd.Parameters.AddWithValue("@nombre", marca.Nombre);
                cmd.Parameters.AddWithValue("@telefono", marca.Telefono ?? "");
                cmd.Parameters.AddWithValue("@representante", marca.Representante ?? "");

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al crear el registro en la base de datos.", ex);
            }
        }

        public static bool Editar(Marca marca)
        {
            string query = "UPDATE marca SET nombre = @nombre, telefono = @telefono, representante = @representante WHERE id_marca = @id_marca";

            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@nombre", marca.Nombre);
                cmd.Parameters.AddWithValue("@telefono", marca.Telefono ?? "");
                cmd.Parameters.AddWithValue("@representante", marca.Representante ?? "");
                cmd.Parameters.AddWithValue("@id_marca", marca.IdMarca);

                int filasAfectas = cmd.ExecuteNonQuery();
                return filasAfectas > 0;
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al actualizar el registro en la base de datos.", ex);
            }
        }

        // Eliminado logico
        public static bool Eliminar(int idMarca)
        {
            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand cmd = new("UPDATE marca SET estado = false WHERE id_marca = @id_marca", conn);
                cmd.Parameters.AddWithValue("@id_marca", idMarca);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al eliminar (logico) el reistro de la base de datos.", ex);
            }
        }
    }
}
