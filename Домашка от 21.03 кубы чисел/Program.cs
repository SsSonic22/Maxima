// See https://aka.ms/new-console-template for more information

Console.WriteLine("Давай вычислим кубы чисел от одного до другого");

Console.WriteLine("Введи число: ");
long num1 = long.Parse(Console.ReadLine());
    
Console.WriteLine("Введи число: ");
long num2 = long.Parse(Console.ReadLine());

long iii = 0;

Console.WriteLine("Получилось такое:");
    
for (long i = num1; i <= num2; i++)
{

    iii = i * i * i;

    Console.WriteLine($"{iii}");
}

Console.ReadKey();