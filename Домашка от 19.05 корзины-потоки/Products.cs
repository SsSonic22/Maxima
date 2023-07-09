namespace ConsoleApp1Домашка_от_25._04_линки_в_корзине;
public class Product
{
    public int Price { get; }
    public string Title { get; }

    public Product(int price, string title)
    {
        Price = price;
        Title = title;
    }

    public override string ToString()
    {
        return $"Title: {Title}. Price: {Price:C0}";
    }
}