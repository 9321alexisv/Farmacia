
using QuestPDF.Infrastructure;
using VistasFarmacia;

namespace Farmacia
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            QuestPDF.Settings.License = LicenseType.Community;

            ApplicationConfiguration.Initialize();
            Application.Run(new FormInicio());
        }
    }
}