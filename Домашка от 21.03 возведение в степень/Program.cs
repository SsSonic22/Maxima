// See https://aka.ms/new-console-template for more information

Console.WriteLine("Сейчас будем возводить числа в степень");

Console.WriteLine("Введи число: ");
int num = int.Parse(Console.ReadLine());
    
Console.WriteLine("Введи степень: ");
int power = int.Parse(Console.ReadLine());
    
double num_power = 1;
    
for(int i = 0; i < power; i++) 
{
    num_power *= num;
}
    
Console.WriteLine($"Получается, что так {num} ^ {power} = {num_power}");
Console.ReadKey();
