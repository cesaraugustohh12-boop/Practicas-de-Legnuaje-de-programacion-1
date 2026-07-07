using PuntoVentaForms.Modelos;

namespace PuntoVentaForms.Forms;

public partial class FormPrincipal : Form
{
    private List<Producto> productos = new List<Producto>();

    private Venta venta = new Venta();

    public FormPrincipal()
    {
        InitializeComponent();

        CargarProductos();
    }

    private void CargarProductos()
    {
        productos.Add(new Producto(1, "Arroz 5lb", "Abarrotes", 250, 20));
        productos.Add(new Producto(2, "Azúcar 1lb", "Abarrotes", 60, 30));
        productos.Add(new Producto(3, "Pasta", "Abarrotes", 80, 25));

        productos.Add(new Producto(4, "Leche", "Bebidas", 70, 15));
        productos.Add(new Producto(5, "Refresco", "Bebidas", 50, 20));
        productos.Add(new Producto(6, "Agua", "Bebidas", 35, 40));

        productos.Add(new Producto(7, "Galletas", "Snacks", 45, 30));
        productos.Add(new Producto(8, "Papitas", "Snacks", 40, 25));
        productos.Add(new Producto(9, "Chocolate", "Snacks", 90, 15));
    }

    private void AgregarProducto(Producto producto)
    {
        string texto = Microsoft.VisualBasic.Interaction.InputBox(
            $"¿Cuántas unidades de {producto.Nombre} desea comprar?",
            "Cantidad",
            "1");

        if (!int.TryParse(texto, out int cantidad))
            return;

        if (cantidad <= 0)
            return;

        if (cantidad > producto.Stock)
        {
            MessageBox.Show(
                "No hay suficiente inventario.",
                "Inventario",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return;
        }

        producto.Stock -= cantidad;

        venta.AgregarProducto(producto, cantidad);

        lstCarrito.Items.Add(
            $"{producto.Nombre}  x{cantidad}   RD${producto.Precio * cantidad}");

        ActualizarTotal();
    }

    private void ActualizarTotal()
    {
        lblTotal.Text =
            $"TOTAL: RD${venta.TotalGeneral():N2}";
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
        if (lstCarrito.SelectedIndex == -1)
            return;

        venta.EliminarProducto(lstCarrito.SelectedIndex);

        lstCarrito.Items.RemoveAt(lstCarrito.SelectedIndex);

        ActualizarTotal();
    }

    private void btnVaciar_Click(object sender, EventArgs e)
    {
        venta.Vaciar();

        lstCarrito.Items.Clear();

        ActualizarTotal();
    }

    private void btnPagar_Click(object sender, EventArgs e)
    {
        if (venta.ProductosComprados.Count == 0)
        {
            MessageBox.Show(
                "No hay productos en el carrito.");
            return;
        }

        FormFactura factura =
            new FormFactura(venta);

        factura.ShowDialog();

        venta = new Venta();

        lstCarrito.Items.Clear();

        ActualizarTotal();
    }

    private void btnArroz_Click(object sender, EventArgs e)
    {
        AgregarProducto(productos[0]);
    }

    private void btnAzucar_Click(object sender, EventArgs e)
    {
        AgregarProducto(productos[1]);
    }

    private void btnPasta_Click(object sender, EventArgs e)
    {
        AgregarProducto(productos[2]);
    }

    private void btnLeche_Click(object sender, EventArgs e)
    {
        AgregarProducto(productos[3]);
    }

    private void btnRefresco_Click(object sender, EventArgs e)
    {
        AgregarProducto(productos[4]);
    }

    private void btnAgua_Click(object sender, EventArgs e)
    {
        AgregarProducto(productos[5]);
    }

    private void btnGalletas_Click(object sender, EventArgs e)
    {
        AgregarProducto(productos[6]);
    }

    private void btnPapitas_Click(object sender, EventArgs e)
    {
        AgregarProducto(productos[7]);
    }

    private void btnChocolate_Click(object sender, EventArgs e)
    {
        AgregarProducto(productos[8]);
    }
}