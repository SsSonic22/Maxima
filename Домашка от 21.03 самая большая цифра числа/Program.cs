// See https://aka.ms/new-console-template for more information

Console.WriteLine("Давай найдём самую большую цифру твоего числа");

Console.WriteLine("Введи число: ");
long num = long.Parse(Console.ReadLine());

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
Console.WriteLine($"Вот эта {maxima}");
Console.ReadKey();