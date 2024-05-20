
using Farmacia.Entidad;
using Npgsql;
using System.Data;

namespace Farmacia.Datos
{
    internal class D_Clientes
    {
        public static List<Cliente> Listar()
        {
            List<Cliente> clientes = [];

            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand comando = new("select * from cliente", conn);
                using NpgsqlDataReader datos = comando.ExecuteReader();

                while (datos.Read())
                {
                    Cliente cliente = new()
                    {
                        IdCliente = (int)datos.GetFieldValue<int>("id_cliente"),
                        Nit = datos.GetFieldValue<string>("nit"),
                        Nombre = datos.GetFieldValue<string>("nombre"),
                        Telefono = datos.GetFieldValue<string>("telefono"),
                        Estado = datos.GetFieldValue<bool>("estado")
                    };

                    clientes.Add(cliente);
                }

                return clientes;
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al obtener todos los registros de la base de datos.", ex);
            }
        }

        public static bool Insertar(Cliente cliente)
        {
            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand cmd = new("INSERT INTO cliente (nit, nombre, telefono) VALUES (@nit, @nombre, @telefono)", conn);
                cmd.Parameters.AddWithValue("@nit", cliente.Nit ?? "");
                cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@telefono", cliente.Telefono ?? "");

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas == 1;
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al crear el registro en la base de datos.", ex);
            }
        }

        public static bool Editar(Cliente cliente)
        {
            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand cmd = new("UPDATE cliente SET nit = @nit, nombre = @nombre, telefono = @telefono WHERE id_cliente = @idCliente", conn);

                cmd.Parameters.AddWithValue("@nit", cliente.Nit ?? "");
                cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@telefono", cliente.Telefono ?? "");
                cmd.Parameters.AddWithValue("@idCliente", cliente.IdCliente);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas == 1;
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al actualizar el registro en la base de datos.", ex);
            }
        }

        // Eliminado logico
        public static bool Eliminar(int idCliente)
        {
            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand cmd = new("UPDATE cliente SET estado = false WHERE id_cliente = @id_cliente", conn);
                cmd.Parameters.AddWithValue("@id_cliente", idCliente);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas == 1;
            }
            catch (NpgsqlException ex)
            {
                throw new Exception("Error al eliminar (logico) el reistro de la base de datos.", ex);
            }
        }
    }
}
