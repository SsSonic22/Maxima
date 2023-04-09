// See https://aka.ms/new-console-template for more information
namespace MaximaHomeWork;

public class Lesson6Calls
{
    static void Main()
    {
        First();
        Second();
        Third();
        Fourth();
        Fifth();
        Sixth();
        Seventh();
        Eighth();
    }
    static void First()
    {
        Console.WriteLine("Сейчас будем возводить числа в степень");

        Console.WriteLine("Введи число: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("Введи степень: ");
        int power = int.Parse(Console.ReadLine());

        Lesson6 ls = new Lesson6();

        double num_power = ls.GetPowerNum(num, power);

        Console.WriteLine($"Получается, что так {num} ^ {power} = {num_power}");
        Console.ReadKey();
    }
    static void Second()
    {
        Console.WriteLine("Давай найдём делители твоего числа");

        Console.WriteLine("Введи число: ");
        long num = long.Parse(Console.ReadLine());
        Console.WriteLine("Вот твои делители");
        Lesson6 ls = new Lesson6();

        ls.GetDividers(num);

        Console.ReadKey();
    }
    static void Third()
    {

        Console.WriteLine("Давай вычислим кубы чисел от одного до другого");

        Console.WriteLine("Введи число: ");
        long num1 = long.Parse(Console.ReadLine());

        Console.WriteLine("Введи число: ");
        long num2 = long.Parse(Console.ReadLine());

        long iii = 0;

        Lesson6 ls = new Lesson6();

        Console.WriteLine("Получилось такое:");

        for (long i = num1; i <= num2; i++)
        {

            iii = ls.NumbersCube(i);

            Console.WriteLine($"{iii}");
        }

        Console.ReadKey();
    }
    static void Fourth()
    {

        Console.WriteLine("Давай найдём самую большую цифру твоего числа");

        Console.WriteLine("Введи число: ");
        long num = long.Parse(Console.ReadLine());

        Lesson6 ls = new Lesson6();

        Console.WriteLine($"Вот эта {ls.GetHighestFigure(num)}");
        Console.ReadKey();
    }
    static void Fifth()
    {
        Console.WriteLine("Давай сложим первую и последнюю цифры твоего числа");

        Console.WriteLine("Введи число: ");
        long num = long.Parse(Console.ReadLine());

        Lesson6 ls = new Lesson6();

        Console.WriteLine($"Как-то так {ls.GetSumm(num)}");

        Console.ReadKey();
    }
    static void Sixth()
    {
        Console.WriteLine("Смотри, сейчас найду  все совершенные числа от 1 до 10000");

        Lesson6 ls = new Lesson6();

        for (int i = 2; i <= 10000; i++)
        {
            ls.GetDividers(i);
        }

        Console.ReadKey();
    }
    static void Seventh()
    {
        Console.WriteLine("Смотрю что покажу");

        int[,] multy = new int[10, 10];

        Lesson6 ls = new Lesson6();

        ls.MultyTable(multy);

        Console.WriteLine("Вот так вот тоже умею");
    }
    static void Eighth()
    {
        Console.WriteLine("Введи своё число: ");
        long num = long.Parse(Console.ReadLine());

        Lesson6 ls = new Lesson6();

        ls.GetEvenUneven(num.ToString());

        Console.ReadKey();
    }

}
