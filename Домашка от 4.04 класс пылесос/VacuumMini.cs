namespace Домашка_от_4._04_класс_пылесос;

//Пылесос мини
public class VacuumMini : Vacuum
{
    public override string Model => GetModel();
    
    public string GetModel()
    {
        return "VacuumMini";
    }

    public new void StartCleaning(string room)
    {
        Console.WriteLine($"Пылесос мини начал уборку в зоне <{room}>");
    }
}