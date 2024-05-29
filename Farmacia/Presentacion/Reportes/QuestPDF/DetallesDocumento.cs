
using Farmacia.Entidad;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace Farmacia.Presentacion.Reportes.QuestPDF
{
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
