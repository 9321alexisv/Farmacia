
using Farmacia.Entidad;
using Npgsql;
using System.Data;

namespace Farmacia.Datos
{
    public class D_Proveedores
    {
        public static List<Proveedor> Listar()
        {
            List<Proveedor> proveedores = [];

            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand comando = new("select * from proveedor;", conn);
                using NpgsqlDataReader datos = comando.ExecuteReader();

                while (datos.Read()) {

                    Proveedor proveedor = new()
                    {
                        IdProveedor = (int)datos.GetFieldValue<int>("id_proveedor"),
                        Nit = datos.GetFieldValue<string>("nit"),
                        Nombre = datos.GetFieldValue<string>("nombre"),
                        Telefono = datos.GetFieldValue<string>("telefono"),
                        Representante = datos.GetFieldValue<string>("representante"),
                        Estado = datos.GetFieldValue<bool>("estado")
                    };

                    proveedores.Add(proveedor);
                }

                return proveedores;
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al obtener todos los registros de la base de datos.", ex);
            }
        }

        public static bool Insertar(Proveedor proveedor)
        {
            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand cmd = new("INSERT INTO proveedor (nit, nombre, telefono, representante) VALUES (@nit, @nombre, @telefono, @representante)", conn);

                cmd.Parameters.AddWithValue("@nit", proveedor.Nit ?? "");
                cmd.Parameters.AddWithValue("@nombre", proveedor.Nombre);
                cmd.Parameters.AddWithValue("@telefono", proveedor.Telefono ?? "");
                cmd.Parameters.AddWithValue("@representante", proveedor.Representante ?? "");

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas == 1;
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al crear el registro en la base de datos.", ex);
            }
        }

        public static bool Actualizar(Proveedor proveedor)
        {
            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand cmd = new("UPDATE proveedor SET nit = @nit, nombre = @nombre, telefono = @telefono, representante = @representante WHERE id_proveedor = @id_proveedor", conn);

                cmd.Parameters.AddWithValue("@nit", proveedor.Nit ?? "");
                cmd.Parameters.AddWithValue("@nombre", proveedor.Nombre);
                cmd.Parameters.AddWithValue("@telefono", proveedor.Telefono ?? "");
                cmd.Parameters.AddWithValue("@representante", proveedor.Representante ?? "");
                cmd.Parameters.AddWithValue("@id_proveedor", proveedor.IdProveedor);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas == 1;
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al actualizar el registro en la base de datos.", ex);
            }
        }

        // Eliminado logico
        public static bool Eliminar(int idProveedor)
        {
            try
            {
                ConexionDB conexion = new();
                using NpgsqlConnection conn = conexion.AbrirConexion()!;
                using NpgsqlCommand comando = new("UPDATE proveedor SET estado = false WHERE id_proveedor = @id_proveedor", conn);
                comando.Parameters.AddWithValue("@id_proveedor", idProveedor);

                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas == 1;
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Error al eliminar (logico) el registro de la base de datos.", ex);
            }
        }
    }
}
