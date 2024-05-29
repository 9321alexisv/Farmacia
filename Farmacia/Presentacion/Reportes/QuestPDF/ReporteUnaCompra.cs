
using Farmacia.Entidad;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using Image = QuestPDF.Infrastructure.Image;

namespace Farmacia.Presentacion.Reportes.QuestPDF
{
    public class ReporteUnaCompra : IDocument
    {
        public static Image Logo { get; } = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logo.png"));

        public Compra Compra { get; }

        public ReporteUnaCompra(Compra compra)
        {
            Compra = compra;
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

        public void Compose(IDocumentContainer container)
        {
            container
                .Page(page =>
                {
                    page.Margin(50);

                    page.Header().Element(Encabezado);
                    page.Content().Element(Contenido);

                    page.Footer().AlignCenter().Text(text =>
                    {
                        text.CurrentPageNumber();
                        text.Span(" / ");
                        text.TotalPages();
                    });
                });
        }

        void Encabezado(IContainer container)
        {
            container.Row(row =>
            {
                row.RelativeItem().Column(column =>
                {
                    column
                        .Item().Text($"Compra No. {Compra.IdCompra}")
                        .FontSize(20).SemiBold().FontColor(Colors.Blue.Medium);

                    column.Item().Text(text =>
                    {
                        text.Span("Fecha Compra: ").SemiBold();
                        text.Span($"{Compra.Fecha:d}");
                    });

                    column.Item().Text(text =>
                    {
                        text.Span("Fecha Documento: ").SemiBold();
                        text.Span(DateTime.Now.ToString());
                    });
                });

                row.ConstantItem(200).Image(Logo);
            });
        }

        void Contenido(IContainer container)
        {

            container.PaddingVertical(40).Column(column =>
            {
                column.Spacing(20);

                // Detalles documento
                column.Item().Row(row =>
                {
                    row.RelativeItem().Component(new DetallesDocumento("Farmacia", Empresa.Instance));
                    row.ConstantItem(50);
                    row.RelativeItem().Component(new DetallesDocumento("Proveedor", Compra.Proveedor));
                });

                // Tabla de productos
                column.Item().Element(Tabla);

                // Total
                var totalPrice = Compra.Productos!.Sum(x => x.PrecioCompra * x.Stock);
                column.Item().PaddingRight(5).AlignRight().Text($"TOTAL: Q {totalPrice}").SemiBold();

                // Footer o comentarios
                column.Item().PaddingTop(25).Element(Comentarios);
                //if (!string.IsNullOrWhiteSpace(Venta.Cliente.Nombre))
                //    column.Item().PaddingTop(25).Element(Comentarios);

            });
        }

        void Tabla(IContainer container)
        {
            var headerStyle = TextStyle.Default.SemiBold();

            container.Table(table =>
            {
                // Definir cantidad de columnas y ancho
                table.ColumnsDefinition(columns =>
                {
                    columns.ConstantColumn(25);
                    columns.RelativeColumn(3);
                    columns.RelativeColumn(2);
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                });

                // Nombre columnas
                table.Header(header =>
                {
                    header.Cell().Text("#");
                    header.Cell().Text("Producto").Style(headerStyle);
                    header.Cell().Text("Marca").Style(headerStyle);
                    header.Cell().AlignRight().Text("Precio unitario").Style(headerStyle);
                    header.Cell().AlignRight().Text("Cantidad").Style(headerStyle);
                    header.Cell().AlignRight().Text("Subtotal").Style(headerStyle);

                    header.Cell().ColumnSpan(6).PaddingTop(5).BorderBottom(1).BorderColor(Colors.Black);
                });

                // Mostrar productos
                foreach (var item in Compra.Productos!)
                {
                    var index = Compra.Productos.IndexOf(item) + 1;

                    table.Cell().Element(CellStyle).Text($"{index}");
                    table.Cell().Element(CellStyle).Text(item.Nombre);
                    table.Cell().Element(CellStyle).Text(item.Marca.Nombre);
                    table.Cell().Element(CellStyle).AlignRight().Text($"Q {item.PrecioCompra}");
                    table.Cell().Element(CellStyle).AlignRight().Text($"{item.Stock}");
                    table.Cell().Element(CellStyle).AlignRight().Text($"Q {item.PrecioCompra * item.Stock}");

                    static IContainer CellStyle(IContainer container) => container.BorderBottom(1).BorderColor(Colors.Grey.Lighten2).PaddingVertical(5);
                }
            });
        }

        void Comentarios(IContainer container)
        {
            container.ShowEntire().Background(Colors.Grey.Lighten3).Padding(10).Column(column =>
            {
                column.Spacing(5);
                column.Item().Text("Aviso").FontSize(14).SemiBold();
                column.Item().Text("Documento con propositos informativos.\nEste documento no tiene caracter oficial ni legal.");
            });
        }
    }

}
