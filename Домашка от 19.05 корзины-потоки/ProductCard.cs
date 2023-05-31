namespace ConsoleApp1Домашка_от_25._04_линки_в_корзине;
using System.Collections.Generic;
using System.Text;

public class ProductCard
{
    public List<Product> Items { get; }
    public ProductCard(List<Product> products)
    {
        Items = products;
    }
    
    public decimal GetTotalSumm()
    {
        decimal summ = 0;
        foreach (var product in Items)
        {
            summ += product.Price;
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