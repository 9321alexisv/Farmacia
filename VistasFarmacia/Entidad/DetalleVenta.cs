
namespace VistasFarmacia.Entidad
{
    public class DetalleVenta
    {
        public int IdDetalleVenta { get; set; }
        public Producto ObjProducto { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
    }
}
