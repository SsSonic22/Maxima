// See https://aka.ms/new-console-template for more information

namespace MaximaHomeWork
{
    class Lesson5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Давай сложим первую и последнюю цифры твоего числа");

            Console.WriteLine("Введи число: ");
            long num = long.Parse(Console.ReadLine());
            
            Console.WriteLine($"Как-то так {GetSumm(num)}");

            Console.ReadKey();
        }

        static long GetSumm(long num)
        {
            long last = num % 10;
            long first = num;
            while (first > 9)
            {
                first /= 10;
            }

            long sum = first + last;
            return sum;
        }
    }
}
