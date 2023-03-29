// See https://aka.ms/new-console-template for more information


namespace MaximaHomeWork
{
    class Lesson5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Давай найдём делители твоего числа");

            Console.WriteLine("Введи число: ");
            long num = long.Parse(Console.ReadLine());
            Console.WriteLine("Вот твои делители");
            GetDividers(num);
            
            Console.ReadKey();
        }

        static void GetDividers(long num)
        {
            for (var i = 2; i <= num / 2; ++i)
                if (num % i == 0)
                    Console.WriteLine($"{i}" + " ");
        }
    }
}