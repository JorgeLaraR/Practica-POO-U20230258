public interface ISuper
{
    void Comprar();
    void Vender();

}

public class Cliente
{
    public string Name { get; set; }
    public string Apellido { get; set; }
}

public class Marca : Cliente
{
    List<Producto> productos { get; set; }
}

public class Producto : ISuper
{
    public string Brand { get; set; }
    public Marca Marca { get; set; }

    public void Vender()
    {
        Console.WriteLine("Se vendió el producto.");
    }

    public void Comprar()
    {
        Console.WriteLine("Se compró el producto.");
    }
}

public class Inventario : Cliente
{
    public void RegistrarCompra(Producto producto, Cliente cliente)
    {
        Console.WriteLine($"El producto {producto.Brand}, de la marca {producto.Marca.Name} lo ha comprado {cliente.Name}");
    }
}

public class User : Cliente
{
    public List<Producto> productosComprados { get; set; }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Marca marca = new Marca { Name = "Kellogg's", Apellido = "Santiago" };
        Producto producto = new Producto { Brand = "Corn Flakes", Marca = marca };

        Inventario inventario = new Inventario { Name = "Isabela", Apellido = "Martínez" };
        User user = new User { Name = "Lucas", Apellido = "Abdiel" };

        inventario.RegistrarCompra(producto, user);
        producto.Comprar();
        producto.Vender();
    }
}