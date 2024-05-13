
namespace VistasFarmacia.Entidad
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public string Proveedor { get; set; }
        public string Fecha {  get; set; }
        public List<DetalleCompra> ObjDetalleCompra { get; set; }
    }
}
