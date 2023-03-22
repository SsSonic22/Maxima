// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введи своё число: ");
long num = long.Parse(Console.ReadLine());
            
string strnum = num.ToString();
long even = 0;
int uneven = 0;
     
foreach (char ch in strnum) 
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
Console.ReadKey();