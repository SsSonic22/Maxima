namespace Домашка_от_4._04_класс_пылесос;

//Моющий пылесос
public class WashingVacuum : Vacuum
{
    public override string Model => GetModel();

    public string GetModel()
    {
        return "WashingVacuum";
    }

    public override void StartCleaning(string room, int dust)
    {
        IfMaximumDust(dust);
        Console.WriteLine($"Моющий пылесос начал уборку в зоне <{room}>");
    }
    public override int MaximumDust => GetMaximumDust();

    public int GetMaximumDust()
    {
        return 38;
    }

    public void  IfMaximumDust (int maxDust)
    {
        if (maxDust > 38)
            throw new TooMuchDustException(string.Format("Can not go on cleaning, my tank is full!!"));
    }
}