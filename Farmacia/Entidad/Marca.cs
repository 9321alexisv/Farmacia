
namespace Farmacia.Entidad
{
    public class Marca
    {
        public required int IdMarca { get; set; }
        public required string Nombre { get; set; }
        public string? Telefono { get; set; }
        public string? Representante { get; set;}
        public bool Estado { get; set; }
    }
}
