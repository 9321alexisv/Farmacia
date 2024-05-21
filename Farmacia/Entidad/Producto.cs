
namespace Farmacia.Entidad
{
    public class Producto
    {
        public required int IdProducto { get; set; }
        public required Marca Marca { get; set; }
        public required string Nombre { get; set; }
        public required decimal PrecioCompra { get; set; }
        public required decimal PrecioVenta { get; set; }
        public required int Stock { get; set; }
        public required int StockMinimo { get; set; }
    }
}
