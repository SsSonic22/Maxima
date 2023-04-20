namespace Домашка_от_4._04_класс_пылесос;

//Класс обычного пылесоса
public class VacuumCleaner : Vacuum
{
    public override string Model => GetModel();

    public string GetModel()
    {
        return "VacuumCleaner";
    }

    public override void StartCleaning(string room, int dust)
    {
        IfMaximumDust(dust);
        StartCleaning();
    }

    public override int MaximumDust => GetMaximumDust();

    public int GetMaximumDust()
    {
        return 79;
    }

    public void  IfMaximumDust (int maxDust)
    {
        if (maxDust > 79)
            throw new TooMuchDustException(string.Format("Can not go on cleaning, my tank is full!!"));
    }
}
