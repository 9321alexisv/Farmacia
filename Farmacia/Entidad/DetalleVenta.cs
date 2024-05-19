
namespace Farmacia.Entidad
{
    public class DetalleVenta
    {
        public int IdDetalleVenta { get; set; }
        public int IdProducto { get; set; }
        public string Producto { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
    }
}
