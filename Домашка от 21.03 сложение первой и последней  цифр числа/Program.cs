// See https://aka.ms/new-console-template for more information

Console.WriteLine("Давай сложим первую и последнюю цифры твоего числа");

Console.WriteLine("Введи число: ");
long num = long.Parse(Console.ReadLine());
    
long last = num % 10;
long first = num;
while (first > 9)
{
    first /= 10;
}
long sum = first + last;
    
Console.WriteLine($"Как-то так {sum}");
    
Console.ReadKey();
