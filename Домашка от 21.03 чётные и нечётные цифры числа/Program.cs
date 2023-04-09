// See https://aka.ms/new-console-template for more information
namespace MaximaHomeWork
{
    class Lesson5
    {
        static void Main()
        {
            Console.WriteLine("Введи своё число: ");
            long num = long.Parse(Console.ReadLine());
            
            GetEvenUneven(num.ToString());
            
            Console.ReadKey();
        }

        static void GetEvenUneven(string number)
        {
            long even = 0;
            int uneven = 0;

            foreach (char ch in number)
            {
                int i = (int)ch;
                if (i % 2 == 0)
                {
                    even++;
                }
                else if (i % 2 != 0)
                {
                    uneven++;
                }
            }
            Console.WriteLine($"Четных чисел {even}, не четных {uneven}");
        }
    }
}