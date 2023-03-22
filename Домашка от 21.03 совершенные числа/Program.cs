// See https://aka.ms/new-console-template for more information

namespace MaximaHomeWork
{
    class Lesson5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Смотри, сейчас найду  все совершенные числа от 1 до 10000");

            for (int i = 2; i <= 10000; i++)
            {
                GetDividers(i);
            }

            Console.ReadKey();
        }

        static void GetDividers(int i)
        {
            int sum = 0;
            for (int divider = 1; divider <= i - 1; divider++)
            {
                if (i % divider == 0)
                {
                    sum += divider;
                }
            }

            if (sum == i)
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}