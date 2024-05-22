
namespace Farmacia.Entidad
{
    public class Venta
    {
        public required int IdVenta { get; set; }
        public required Cliente Cliente { get; set; }
        public required DateTime Fecha { get; set; }
        public List<Producto>? Productos { get; set; }
    }
}
