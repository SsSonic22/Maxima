namespace Домашка_от_26._05_таски;

class Program
{
    private static object _sync = new object();
    static decimal[] list = { 1, 7, 8, 20, 9, 3, 2, 2, 6 };
    private static int index = 0;
    static void Main()
    {
        

        for (int i = 0; i < 4; i++)
        {
            Task.Factory.StartNew(() =>
            {
                GetFactorial();
            });
        }

        

    }
    private static void GetFactorial()
    {
        decimal n = 0;
        lock (_sync)
        {
            n = list[index];
            index++;
        }

        long factorial = 1;
        for (int i = 2; i <= n; i++)
            {
                factorial = factorial * i;
                Console.WriteLine($"Факториал числа {n} равен {factorial}");
            }
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