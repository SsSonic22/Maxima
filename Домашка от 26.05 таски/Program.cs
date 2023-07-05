using System.Diagnostics;

namespace Домашка_от_26._05_таски;

class Indexer
{
    public Indexer()
    {
        _index = 0;
    }
    public int Index
    {
        get => _index;
        set => _index = value;
    }
    private static int _index = 0;
}

class Program
{
    private static object _sync = new object();
    static int[] numbers;
    private static int N = 16;
    private static Random r = new Random();

    // Переделать предыдущее домашнее задание по потокам на использование Task.
    // Написать программу. Дан список чисел(одномерный массив). 
    // Нужно в количестве равном N создать таски, внутри которых будет расчет 
    // факториалов для каждого числа из заданного списка. То есть параллельно 
    // пробежаться по списку чисел и распораллелить вычисление факториалов. 
    // Измерить время выполнения для однопоточной обработки списка(N=1) и для N=4(степень параллелизма) 

    // 1) У тебя количество потоков равно количеству чисел, а задача в другом:
    // потоков должно быть N, вне зависимости от того, сколько чисел. 
    // Кроме того, у тебя каждый поток считает только 1 число, а надо, чтобы он 
    // мог брать пачку чисел и считать несколько 2) Нет расчёта времени выполнения для N = 1 и для N = 4
    static void Main(string[] args)
    {
        numbers = Enumerable.Range(1, 20000000).Select(n => r.Next(2, 27)).ToArray();
        
        var firstTime = CalculateAllFactorialsByNThreads(N);
        
        var secondtTime = CalculateAllFactorialsByNThreads(1);

        if (firstTime > secondtTime)
            Console.WriteLine($"firstTime медленнее на {firstTime - secondtTime} миллисекунд");
        
        else if (firstTime < secondtTime)
            Console.WriteLine($"secondtTime медленнее на {secondtTime - firstTime} миллисекунд");
        
        else
            Console.WriteLine("одинаково быстрые");
    }

    private static long CalculateAllFactorialsByNThreads(int n)
    {
        Stopwatch time = new Stopwatch();
        List<Task> tasks = new List<Task>();
        Indexer currIndex = new Indexer();
        time.Start();

        for (int i = 0; i < n; i++)
        {
            tasks.Add(new Task(() => CalculateAllFactorials(ref currIndex)));
            tasks.Last().Start();
        }

        Task.WaitAll(tasks.ToArray());
        time.Stop();
        return time.ElapsedMilliseconds;
    }

    private static bool TryCalculateOneFactorial(ref Indexer index)
    {
        decimal n = 0;
        lock (_sync)
        {
            if (index.Index < numbers.Length)
            {
                n = numbers[index.Index];
                index.Index += 1;
            }
            else
            {
                return false;
            }
        }

        decimal factorial = 1;
        for (decimal i = 2; i <= n; i++)
        {
            factorial *= i;
        }
        // Console.WriteLine($"Факториал числа {n} равен {factorial}");
        return true;
    }

    private static void CalculateAllFactorials(ref Indexer index)
    {
        while (TryCalculateOneFactorial(ref index));
    }
}
    