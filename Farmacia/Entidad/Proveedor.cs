
namespace Farmacia.Entidad
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public string? Nit { get; set; }
        public required string Nombre { get; set; }
        public string? Telefono { get; set; }
        public string? Representante { get; set; }
        public bool Estado { get; set; }

        // Propiedad personalizada para concatenar IdProveedor y Nombre
        public string NombreNit => $"{Nombre} - NIT: {Nit}";
    }
}
