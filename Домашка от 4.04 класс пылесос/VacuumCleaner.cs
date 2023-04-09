namespace Домашка_от_4._04_класс_пылесос;

//Класс обычного пылесоса
public class VacuumCleaner : Vacuum
{
    public override string Model => GetModel();

    public string GetModel()
    {
        return "VacuumCleaner";
    }

    public override void StartCleaning(string room)
    {
        StartCleaning();
    }
}