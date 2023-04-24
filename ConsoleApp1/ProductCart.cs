using System.Text;

namespace ConsoleApp1;

public class ProductCard
{
    public List<Product> Items { get; }


    public delegate void NotifyAddedProduct(Product product);

    private readonly NotifyAddedProduct _notifyAddedProduct;

    public ProductCard(NotifyAddedProduct notifyAddedProduct)
    {
        Items = new List<Product>();
        _notifyAddedProduct = notifyAddedProduct;
    }

    public void AddProduct(Product product)
    {   
        Items.Add(product);
        _notifyAddedProduct(product);
    }



    public decimal GetTotalSumm()
    {
        decimal summ = 0;
        foreach (var product in Items)
        {
            summ += product.Price;
        }

        if (summ > 1000)
        {
            return summ * 0.95M;
        }
        if (summ > 100)
        {
            return summ * 0.975M;
        }
        if (summ > 25)
        {
            return summ * 0.99M;
        }

        return summ;
    }

    public string PrintAllProduct()
    {
        StringBuilder stringBuilder = new StringBuilder();
        foreach (var product in Items)
        {
            stringBuilder.AppendLine(product.ToString());
        }

        return stringBuilder.ToString();
    }


}