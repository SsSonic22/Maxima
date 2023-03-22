// See https://aka.ms/new-console-template for more information



namespace MaximaHomeWork
{
    class Lesson5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сейчас будем возводить числа в степень");

            Console.WriteLine("Введи число: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Введи степень: ");
            int power = int.Parse(Console.ReadLine());

            double num_power = GetPowerNum(num, power);

            Console.WriteLine($"Получается, что так {num} ^ {power} = {num_power}");
            Console.ReadKey();
        }



        static double GetPowerNum(int num, int power)
        {
            double num_power = 1;

            for (int i = 0; i < power; i++)
            {
                num_power *= num;
            }

            return num_power;
        }
    }
}