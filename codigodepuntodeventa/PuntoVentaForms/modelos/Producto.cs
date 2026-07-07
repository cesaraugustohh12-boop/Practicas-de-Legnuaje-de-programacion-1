namespace PuntoVentaForms.Modelos;

public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Categoria { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }

    public Producto(int id, string nombre, string categoria, decimal precio, int stock)
    {
        Id = id;
        Nombre = nombre;
        Categoria = categoria;
        Precio = precio;
        Stock = stock;
    }

    public decimal ObtenerSubtotal(int cantidad)
    {
        return Precio * cantidad;
    }

    public override string ToString()
    {
        return $"{Nombre} - RD${Precio}";
    }
}