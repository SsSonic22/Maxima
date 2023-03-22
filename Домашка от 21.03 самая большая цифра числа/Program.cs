// See https://aka.ms/new-console-template for more information


namespace MaximaHomeWork
{
    class Lesson5
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Давай найдём самую большую цифру твоего числа");

            Console.WriteLine("Введи число: ");
            long num = long.Parse(Console.ReadLine());

            Console.WriteLine($"Вот эта {GetHighestFigure(num)}");
            Console.ReadKey();
        }

        static long GetHighestFigure(long num)
        {
            long maxima = 0;

            while (num > 0)
            {
                long t = num % 10;
                if (t > maxima)
                {
                    maxima = t;
                }

                num = num / 10;
            }

            return maxima;
        }
    }
}