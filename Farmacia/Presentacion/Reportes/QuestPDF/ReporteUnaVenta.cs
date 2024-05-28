
using Farmacia.Entidad;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using QuestPDF.Helpers;
using Image = QuestPDF.Infrastructure.Image;
using Path = System.IO.Path;

namespace Farmacia.Presentacion.Reportes.QuestPDF
{
    public class ReporteUnaVenta : IDocument
    {
        public static Image Logo { get; } = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logo.png"));

        public Venta Venta { get; }

        public ReporteUnaVenta(Venta venta)
        {
            Venta = venta;
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
                        .Item().Text($"No. Venta #{Venta.IdVenta}")
                        .FontSize(20).SemiBold().FontColor(Colors.Blue.Medium);

                    column.Item().Text(text =>
                    {
                        text.Span("Fecha Venta: ").SemiBold();
                        text.Span($"{Venta.Fecha:d}");
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
                    row.RelativeItem().Component(new DetallesDocumento("Cliente", Venta.Cliente));
                });

                // Tabla de productos
                column.Item().Element(Tabla);

                // Total
                var totalPrice = Venta.Productos!.Sum(x => x.PrecioVenta * x.Stock);
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
                foreach (var item in Venta.Productos!)
                {
                    var index = Venta.Productos.IndexOf(item) + 1;

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

    public class DetallesDocumento : IComponent
    {
        private string Title { get; }
        private IPersona Persona { get; }

        public DetallesDocumento(string title, IPersona persona)
        {
            Title = title;
            Persona = persona;
        }

        public void Compose(IContainer container)
        {
            container.ShowEntire().Column(column =>
            {
                column.Spacing(2);

                column.Item().Text(Title).SemiBold();
                column.Item().PaddingBottom(5).LineHorizontal(1);

                column.Item().Text(Persona.Nit ?? "");
                column.Item().Text(Persona.Nombre);
                column.Item().Text(Persona.Telefono ?? "");
                if (Title == "Farmacia")
                {
                    column.Item().Text("Huehuetenango, Huehuetenango");
                }
            });
        }
    }
}