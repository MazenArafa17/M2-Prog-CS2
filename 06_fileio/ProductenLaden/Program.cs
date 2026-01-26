namespace ProductenLaden;

using System.Configuration.Assemblies;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
        program.RunProducten();
    }
    private void RunProducten()
    {
        string text = File.ReadAllText("Producten.json");
        Product[] products = JsonSerializer.Deserialize<Product[]>(text);
        foreach (Product product in products)
        {
            Console.WriteLine($"Name: {product.Name}");
            Console.WriteLine($"Description: {product.Description}");
            Console.WriteLine($"Price: {product.Price}");
        }
    }
    private void Run()
    {
        string text = File.ReadAllText("Product.json");
        Product product = JsonSerializer.Deserialize<Product>(text);
        Console.WriteLine($"Name: {product.Name}");
        Console.WriteLine($"Description: {product.Description}");
        Console.WriteLine($"Price: {product.Price}");

    }
}
