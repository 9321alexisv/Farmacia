
using Farmacia.Entidad;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using QuestPDF.Helpers;
using Image = QuestPDF.Infrastructure.Image;
using Path = System.IO.Path;

namespace Farmacia.Presentacion.Reportes
{
    public class ReporteVariasVentas: IDocument
    {
        public static Image Logo { get; } = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logo.png"));

        public List<Venta> Ventas { get; }
        public DateTime? FechaInicio { get; }
        public DateTime? FechaFin { get; }


        public ReporteVariasVentas(List<Venta> venta, DateTime? fechaInicio, DateTime? fechaFin)
        {
            Ventas = venta;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
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
                        .Item().Text("Reporte de Ventas")
                        .FontSize(20).SemiBold().FontColor(Colors.Blue.Medium);

                    column.Item().Text(text =>
                    {
                        text.Span("Desde: ").SemiBold();
                        text.Span($"{FechaInicio:d}");
                    });

                    column.Item().Text(text =>
                    {
                        text.Span("Hasta: ").SemiBold();
                        text.Span($"{FechaFin:d}");
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

                // Detalles por cada venta
                foreach (var venta in Ventas)
                {
                    column.Item().Element(c => EncabezadoVenta(c, venta));
                    column.Item().Element(c => Tabla(c, venta));
                    var totalVenta = venta.Productos.Sum(p => p.PrecioVenta * p.Stock);
                    column.Item().PaddingRight(5).AlignRight().Text($"Total Venta: Q {totalVenta}").SemiBold();
                }

                // Total general
                var totalGeneral = Ventas.Sum(v => v.Productos.Sum(p => p.PrecioVenta * p.Stock));
                column.Item().PaddingRight(5).AlignRight().Text($"TOTAL GENERAL: Q {totalGeneral}").Bold();

                // Footer o comentarios
                column.Item().PaddingTop(25).Element(Comentarios);
            });
        }

        void EncabezadoVenta(IContainer container, Venta venta)
        {
            container.Row(row =>
            {
                row.ConstantItem(50).Text($"# {venta.IdVenta}").SemiBold().FontColor(Colors.Blue.Medium);
                row.ConstantItem(20); // Espaciado entre elementos
                row.ConstantItem(150).Text(text =>
                {
                    text.Span("Fecha: ").SemiBold();
                    text.Span($"{venta.Fecha:d}");
                });
                row.ConstantItem(20); // Espaciado entre elementos
                row.RelativeItem().Text(text =>
                {
                    text.Span("Cliente: ").SemiBold();
                    text.Span(venta.Cliente.NombreNit);
                });
            });
        }

        void Tabla(IContainer container, Venta venta)
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
                foreach (var item in venta.Productos!)
                {
                    var index = venta.Productos.IndexOf(item) + 1;

                    table.Cell().Element(CellStyle).Text($"{index}");
                    table.Cell().Element(CellStyle).Text(item.Nombre);
                    table.Cell().Element(CellStyle).Text(item.Marca.Nombre);
                    table.Cell().Element(CellStyle).AlignRight().Text($"Q {item.PrecioVenta}");
                    table.Cell().Element(CellStyle).AlignRight().Text($"{item.Stock}");
                    table.Cell().Element(CellStyle).AlignRight().Text($"Q {item.PrecioVenta * item.Stock}");

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