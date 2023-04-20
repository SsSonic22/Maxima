namespace Домашка_от_4._04_класс_пылесос;

//Пылесос мини
public class VacuumMini : Vacuum
{
    public override string Model => GetModel();
    
    public string GetModel()
    {
        return "VacuumMini";
    }

    public new void StartCleaning(string room, int dust)
    {
        IfMaximumDust(dust);
        Console.WriteLine($"Пылесос мини начал уборку в зоне <{room}>");
    }
    public override int MaximumDust => GetMaximumDust();

    public int GetMaximumDust()
    {
        return 25;
    }

    public void  IfMaximumDust (int maxDust)
    {
        if (maxDust > 25)
            throw new TooMuchDustException(string.Format("Can not go on cleaning, my tank is full!!"));
    }
}