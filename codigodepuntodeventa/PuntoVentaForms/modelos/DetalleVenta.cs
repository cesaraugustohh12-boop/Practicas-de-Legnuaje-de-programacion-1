namespace PuntoVentaForms.Modelos;

public class DetalleVenta
{
    public Producto Producto { get; set; }

    public int Cantidad { get; set; }

    public DetalleVenta(Producto producto, int cantidad)
    {
        Producto = producto;
        Cantidad = cantidad;
    }

    public decimal CalcularSubtotal()
    {
        return Producto.Precio * Cantidad;
    }
}