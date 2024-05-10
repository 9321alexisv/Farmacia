
namespace VistasFarmacia.Entidad
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public Proveedor ObjProveedor { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioCompra {  get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock {  get; set; }
    }
}
