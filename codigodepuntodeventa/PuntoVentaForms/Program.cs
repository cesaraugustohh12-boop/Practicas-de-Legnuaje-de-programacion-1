using PuntoVentaForms.Forms;

namespace PuntoVentaForms;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        Application.Run(new FormPrincipal());
    }
}