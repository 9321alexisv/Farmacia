
namespace Farmacia.Entidad
{
    internal class Marca
    {
        public int IdMarca { get; set; }
        public required string Nombre { get; set; }
        public string? Telefono { get; set; }
        public string? Representante { get; set;}
        public bool Estado { get; set; }
    }
}
