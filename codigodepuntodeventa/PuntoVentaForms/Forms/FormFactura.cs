using PuntoVentaForms.Modelos;

namespace PuntoVentaForms.Forms;

public partial class FormFactura : Form
{
    private Venta venta;

    private static int numeroFactura = 1;

    public FormFactura(Venta ventaActual)
    {
        InitializeComponent();

        venta = ventaActual;

        MostrarFactura();
    }

    private void MostrarFactura()
    {
        txtFactura.Clear();

        txtFactura.AppendText("=========================================\r\n");
        txtFactura.AppendText("        MINI MERCADO LA CANASTA\r\n");
        txtFactura.AppendText("=========================================\r\n");

        txtFactura.AppendText($"Factura No.: {numeroFactura}\r\n");
        txtFactura.AppendText($"Fecha: {DateTime.Now:dd/MM/yyyy}\r\n");
        txtFactura.AppendText($"Hora : {DateTime.Now:HH:mm:ss}\r\n");

        txtFactura.AppendText("-----------------------------------------\r\n");

        foreach (DetalleVenta item in venta.ProductosComprados)
        {
            txtFactura.AppendText(
                $"{item.Producto.Nombre}\r\n");

            txtFactura.AppendText(
                $"   {item.Cantidad} x RD${item.Producto.Precio} = RD${item.CalcularSubtotal()}\r\n\r\n");
        }

        txtFactura.AppendText("-----------------------------------------\r\n");

        txtFactura.AppendText(
            $"Subtotal : RD${venta.Total()}\r\n");

        txtFactura.AppendText(
            $"ITBIS (18%): RD${venta.ITBIS()}\r\n");

        txtFactura.AppendText(
            $"TOTAL : RD${venta.TotalGeneral()}\r\n");

        txtFactura.AppendText("=========================================\r\n");
        txtFactura.AppendText("      ¡Gracias por su compra!\r\n");
        txtFactura.AppendText("=========================================\r\n");

        numeroFactura++;
    }

    private void btnCerrar_Click(object sender, EventArgs e)
    {
        Close();
    }
}