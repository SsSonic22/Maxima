

// Даны целые числа K1 и K2 и целочисленные последовательности A и B. Получить последовательность,
// содержащую все числа из A, большие K1, и все числа из B, меньшие K2. Отсортировать полученную
// последовательность по возрастанию.

public class Program
{
    public static void Main()
    {

        var K1 = 15;
        var K2 = 22;
        
        var A = new List<int> { 1, 2, 3, 4, 3, 5, 6, 7, 8, 7, 9, 10, 11, 12, 11, 12, 13, 14, 15, 16, 15, 17, 19, 20 };
        var B = new List<int> { 55, 6, 2, 41, 21, 11, 4, 9, 8, 8, 5, 6, 23, 17, 19, 12, 32 };

        var result = A.Where(x => x > K1)
                .Concat(B.Where(x => x < K2))
                .OrderBy(x => x)
                .ToList();
        
        foreach (var i in result)
 
            Console.WriteLine($"{i}");
        Console.ReadKey();
    }
}