
namespace Farmacia.Entidad
{
    public class Empresa: IPersona
    {
        public required string Nit { get; set; }
        public required string Nombre { get; set; }
        public required string Telefono { get; set; }

        // Clase estática interna para manejar el Singleton
        private static class SingletonHolder
        {
            internal static readonly Empresa Instance = new Empresa
            {
                Nit = "123456",
                Nombre = "Farmacia Candelaria",
                Telefono = "1122-3344"
            };
        }

        // Propiedad para acceder a la instancia Singleton de la Empresa
        public static Empresa Instance => SingletonHolder.Instance;
    }
}
