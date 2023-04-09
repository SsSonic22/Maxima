namespace Домашка_от_4._04_класс_пылесос;

//Моющий пылесос
public class WashingVacuum : Vacuum
{
    public override string Model => GetModel();

    public string GetModel()
    {
        return "WashingVacuum";
    }

    public override void StartCleaning(string room)
    {
        Console.WriteLine($"Моющий пылесос начал уборку в зоне <{room}>");
    }
}