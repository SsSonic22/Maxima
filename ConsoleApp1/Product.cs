namespace ConsoleApp1;

public class Product
{
    public decimal Price { get;  }
    public string Title { get; }

    public Product(decimal price, string title)
    {
        Price = price;
        Title = title;
    }

    public override string ToString()
    {
        return $"Title: {Title}. Price: {Price:C0}";
    }
}