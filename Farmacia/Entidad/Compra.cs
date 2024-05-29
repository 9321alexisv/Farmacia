
namespace Farmacia.Entidad
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public required Proveedor Proveedor { get; set; }
        public required DateTime Fecha { get; set; }
        public List<Producto>? Productos { get; set; }
    }
}
