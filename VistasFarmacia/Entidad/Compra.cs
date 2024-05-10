
namespace VistasFarmacia.Entidad
{
    public class Compra
    {
        public string IdCompra { get; set; }
        public Proveedor ObjProveedor { get; set; }
        public string FechaCompra { get; set; }
        public List<DetalleCompra> ObjDetalleCompra { get; set; }
    }
}
