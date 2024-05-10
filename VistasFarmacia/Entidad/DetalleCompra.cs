
namespace VistasFarmacia.Entidad
{
    public class DetalleCompra
    {
        public int IdDetalleCompra {  get; set; }
        public Producto ObjProducto { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
    }
}
