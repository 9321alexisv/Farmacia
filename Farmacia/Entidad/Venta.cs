
namespace Farmacia.Entidad
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public string Cliente { get; set; }
        public string Fecha { get; set; }
        public List<DetalleVenta> ObjDetalleVenta { get; set; }
    }
}
