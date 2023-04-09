// See https://aka.ms/new-console-template for more information

namespace ConsoleApp1
{
    class Lesson6
    {
        static long Fibonache(int i)
        {
            if ((i == 0) || ( i== 1))
                return i;
            return Fibonache(i - 1) + Fibonache(i - 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Давай напишем рекурсию для вычисления одного элемента последовтельности Фиббоначчи от 1 до 20");

            Console.WriteLine("Какой хочешь? Пиши: ");
            int num = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Вот твой элемент {Fibonache(num)}");
            Console.ReadKey();
        }
    }
}