
namespace VistasFarmacia.Entidad
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public Cliente ObjCliente { get; set; }
        public string FechaVenta { get; set; }
        public List<DetalleVenta> ObjDetalleVenta { get; set; }
    } 
}
