namespace Домашка_от_26._05_таски;

class Program
{
    private static object _sync = new object();

    static void Main()
    {
        decimal[] list = { 1, 7, 8, 20, 9, 3, 2, 2, 6 };
        
        // Task? task1 = null;
        // Task? task2 = null;
        // Task? task3 = null;
        // Task? task4 = null;

        for (int i = 0; i < 4; i++)
        {
            Task.Run(() => GetFactorial(list[i]));
        }

        // int i1 = 0;
        // Task? task1 = null;
        // while(i1 < list.Length)
        // {
        //     decimal n = list[i1];
        //     task1 = new Task(() => GetFactorial(n));
        //     i1 += 4;
        // }
        //
        // int i2 = 1;
        // Task? task2 = null;
        // while(i2 < list.Length)
        // {
        //     task2 = new Task(() => GetFactorial(list[i2]));
        //     i2 += 4;
        // }
        // int i3 = 2;
        // Task? task3 = null;
        // while(i3 < list.Length)
        // {
        //     task3 = new Task(() => GetFactorial(list[i3]));
        //     i3 += 4;
        // }
        // int i4 = 3;
        // Task? task4 = null;
        // while(i4 < list.Length)
        // {
        //     task4 = new Task(() => GetFactorial(list[i4]));
        //     i4 += 4;
        // }
        //
        // if (task1 != null) task1.Start();
        // if (task2 != null) task2.Start();
        // if (task3 != null) task3.Start();
        // if (task4 != null) task4.Start();
    }
    private static void GetFactorial(decimal n) 
    {
        long factorial = 1;
        for (int i = 2; i <= n; i++)
        {
            factorial = factorial * i;
        }

        Console.WriteLine($"Факториал числа {n} равен {factorial}");
    }
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