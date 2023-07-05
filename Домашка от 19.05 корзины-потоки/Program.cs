using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1Домашка_от_25._04_линки_в_корзине;
using System.Linq;

class Program
{
    static void Main()
    {
        var carrot = new Product(12, "carrot");
        var apple = new Product(15, "apple");
        var sourCream = new Product(49, "sourCream");
        var dishSoap = new Product(159, "dishSoap");
        var wine = new Product(699, "wine");
        var milk = new Product(89, "milk");
        var gum = new Product(25, "milk");
        var beef = new Product(799, "beef");
        var eggs = new Product(98, "eggs");
        var mustard = new Product(127, "mustard");
        var coffee = new Product(479, "coffee");
        
        var card1 = new ProductCard(new List<Product>() { dishSoap, apple, coffee, milk });
        var card2 = new ProductCard(new List<Product>() { carrot, eggs, beef, gum, wine, dishSoap });
        var card3 = new ProductCard(new List<Product>() { beef, sourCream, mustard, milk, dishSoap });
        var card4 = new ProductCard(new List<Product>() { gum, apple, coffee, eggs, wine, wine });
        var card5 = new ProductCard(new List<Product>() { sourCream, carrot, apple });
        var card6 = new ProductCard(new List<Product>() { mustard, dishSoap, sourCream });

        var listOfCards = new List<ProductCard>() { card1, card2, card3, card5, card4, card6 };

        decimal wholeSum = 0;
        decimal sum = 0;
        
        
        AutoResetEvent flag = new AutoResetEvent(false);
        List<Thread> Threads = new List<Thread>();
        foreach (var card in listOfCards)
        {
            var thread = new Thread(j =>
            {
                wholeSum = card.GetTotalSumm();
                sum += wholeSum;
                flag.Set();
            });
            Threads.Add(thread);
            thread.Start();
        }

        WaitHandle.WaitAll(new[] { flag }, TimeSpan.FromSeconds(1));

        Console.WriteLine($"Result: {sum}");
        
        // // выбрать такие корзины, в которых сумма всех продуктов больше 100
        // var test1 = listOfCards
        //     .Select(l => l)
        //     .Where(l => l.GetTotalSumm() > 100)
        //     .ToArray();
        //
        // // выбрать такие продукты, у которых название длинее 5 символов и цена больше 100
        // var test2 = listOfCards
        //     .SelectMany(c => c.Items)
        //     .Where(p => p.Price > 100)
        //     .Where(p => p.Title.Length > 5)
        //     .OrderBy(x => x.Price)
        //     .ToArray();
        //
        // // выбрать такие корзины, у которых более 4 продуктов 
        // var test3 = listOfCards
        //     .Select(c => c)
        //     .Where(l => l.Items.Count > 4)
        //     .ToArray();
        //
        // // выбрать продукты из всех корзин, у которых цена в интервале от 10 до 100
        // var test4 = listOfCards
        //     .SelectMany(l => l.Items)
        //     .Where(p => p.Price > 10 && p.Price < 100)
        //     .ToArray();
        //
        // // выбрать для каждой корзины продукт с максимальной ценой в рамках данной корзины
        // var maxPricedProducts = new List<Product>();
        //
        // foreach (var card in listOfCards)
        // {
        //     var maxPricedProduct = card.Items
        //         .MaxBy(p => p.Price);
        //     maxPricedProducts.Add(maxPricedProduct);
        // }
        // maxPricedProducts.ToArray();
        //
        // // посчитать сумму всех продуктов в рамках каждой корзины
        // var test6 = listOfCards
        //     .Select(l => l.GetTotalSumm())
        //     .ToArray();
        //
        // // поситчать сумму всех продуктов для всех корзин суммарно
        // var test7 = listOfCards
        //     .Select(c => c.GetTotalSumm())
        //     .Sum(s => s);

    }
}