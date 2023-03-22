// See https://aka.ms/new-console-template for more information

Console.WriteLine("Давай найдём делители твоего числа");

Console.WriteLine("Введи число: ");
long num = long.Parse(Console.ReadLine());
Console.WriteLine("Вот твои делители");
    
for (var i = 2; i <= num / 2; ++i) 
    if (num % i == 0)
        Console.WriteLine($"{i}");
    
Console.ReadKey();