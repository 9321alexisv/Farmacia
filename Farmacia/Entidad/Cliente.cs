
namespace Farmacia.Entidad
{
    public class Cliente: IPersona
    {
        public int IdCliente { get; set; }
        public string? Nit { get; set; }
        public required string Nombre { get; set; }
        public string? Telefono { get; set; }
        public bool Estado { get; set; }
        public string NombreNit => $"{Nombre} - {Nit}";
    }
}
