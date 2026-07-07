namespace PuntoVentaForms.Modelos;

public class Venta
{
    public List<DetalleVenta> ProductosComprados { get; set; }

    public Venta()
    {
        ProductosComprados = new List<DetalleVenta>();
    }

    public void AgregarProducto(Producto producto, int cantidad)
    {
        ProductosComprados.Add(
            new DetalleVenta(producto, cantidad)
        );
    }

    public void EliminarProducto(int indice)
    {
        if (indice >= 0 && indice < ProductosComprados.Count)
        {
            ProductosComprados.RemoveAt(indice);
        }
    }

    public void Vaciar()
    {
        ProductosComprados.Clear();
    }

    public decimal Total()
    {
        decimal total = 0;

        foreach (DetalleVenta item in ProductosComprados)
        {
            total += item.CalcularSubtotal();
        }

        return total;
    }

    public decimal ITBIS()
    {
        return Total() * 0.18m;
    }

    public decimal TotalGeneral()
    {
        return Total() + ITBIS();
    }
}