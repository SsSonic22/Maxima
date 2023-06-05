using System.Diagnostics;

namespace Домашка_от_26._05_таски;

class Program
{
    private static object _sync = new object();
    static decimal[] numbers = { 4, 7, 8, 20, 1, 3, 2, 2, 6 };
    private static int index = 0;
    static void Main(string[] args)
    {
        Stopwatch time = new Stopwatch();
        List<Task> tasks = new List<Task>();

        int n = 0;
        time.Start();
        while (n < numbers.Length)
        {
            for (int i = 0; i < 4; i++)
            {
                tasks.Add(new Task(GetFactorialAction));
                tasks.Last().Start();
            }

            n += 1;
        }
        Task.WaitAll(tasks.ToArray());
        time.Stop();
        var firstTime = time.ElapsedMilliseconds;
        
        int m = 0;
        time.Start();
        var task = Task.Factory.StartNew(() =>
        {
            while (m < numbers.Length)
            {
                GetFactorialAction();
                m += 1;
            }
        });
        Task.WaitAll(task);
        time.Stop();
        var secondtTime = time.ElapsedMilliseconds;

        if (firstTime > secondtTime)
            Console.WriteLine("firstTime медленнее");
        if (firstTime < secondtTime)
            Console.WriteLine("secondtTime медленнее");
        else
            Console.WriteLine("одинаково быстрые");
    
    }

    private static void GetFactorialAction()
    {
        decimal n = 0;
        lock (_sync)
        {
            if (index < numbers.Length)
            {
                n = numbers[index];
                index += 1;
            }
            else
            {
                return;
            }
        }

        long factorial = 1;
        for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }
        Console.WriteLine($"Факториал числа {n} равен {factorial}");
    }
    // private static void GetFactorialAction()
    // {
    //     decimal n = 0;
    //     lock (_sync)
    //     {
    //         n = numbers[index];
    //         index++;
    //     }
    //
    //     long factorial = 1;
    //     for (int i = 2; i <= n; i++)
    //         {
    //             factorial = factorial * i;
    //             Console.WriteLine($"Факториал числа {n} равен {factorial}");
    //         }
    // }
    /// для каждого потока своё число
    /// есть у нас массив
    /// к нему обращаемся по индексу
    /// в каждой таске через += 4 и номеру таски
    ///
    /// разделить массив через линки
    ///
    /// i = 0 снаружи тасков
    /// 
}