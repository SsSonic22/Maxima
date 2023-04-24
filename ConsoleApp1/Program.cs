// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {

        var pr1 = new Product(100, "pr1");
        var pr2 = new Product(99, "pr2");
        var pr3 = new Product(10, "pr3");

        Console.WriteLine("perekrestok");

        var productCardperekrestok = new ProductCard(NotifyPerekrestok);
        productCardperekrestok.AddProduct(pr1);
        productCardperekrestok.AddProduct(pr2);
        productCardperekrestok.AddProduct(pr3);

        Console.WriteLine("DIKSI");

        var productCardDiksi = new ProductCard(NotifyDiksi);
        productCardDiksi.AddProduct(pr1);
        productCardDiksi.AddProduct(pr2);
        productCardDiksi.AddProduct(pr3);

        // Console.WriteLine(productCard.PrintAllProduct());
        //Console.WriteLine($"Total: {productCardperekrestok.GetTotalSumm():C0}");
    }

    public static void NotifyPerekrestok(Product product)
    {
        Console.WriteLine($"Added new product: {product}");
    }

    public static void NotifyDiksi(Product product)
    {
        Console.WriteLine($"Welcome! Added new product: {product}");
    }
}