

// Даны целые числа K1 и K2 и целочисленные последовательности A и B. Получить последовательность,
// содержащую все числа из A, большие K1, и все числа из B, меньшие K2. Отсортировать полученную
// последовательность по возрастанию.
    
public class Program
{
    public static void Main()
    {
        int K1 = 15;
        int K2 = 25;
        
        var A = new List<int> { 1, 5, 2, 3, 4, 45, 6, 7, 8, 10, 11, 26, 13, 12, 14, 15, 18, 20, 21 };
        var B = new List<int> { 1, 8, 4, 77, 23, 4, 3, 4, 9, 6, 21, 8, 9, 8, 10, 11, 35, 13, 12, 16, 19, 18, 83, 29, 21 };

        var result = A.Where(x => x > K1)
                .Concat(B.Where(x => x < K2))
                .OrderBy(x => x)
                .ToList();
        
        foreach (var i in result)
 
            Console.WriteLine($"{i}");
        
        Console.ReadKey();
    }
}