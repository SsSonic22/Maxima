namespace Домашка_от_11._04_пЫлЕсОсЫ;

class Program
{
    static void Main()
    {
        var vacuum1 = new VacuumCleaner();
        var vacuum3 = new WashingVacuum();
        var vacuum2 = new VacuumMini();
        
        vacuum1.StartCleaning("кухня", 25);
        vacuum3.StartCleaning("ванная комната", 15);
        vacuum2.StartCleaning("спальня", 10);

        Console.WriteLine($"{vacuum1.GetColor<string>()}");
        Console.WriteLine($"{vacuum2.GetColor<int>()}");
        Console.WriteLine($"{vacuum3.GetColor<Color>()}");
    }
}