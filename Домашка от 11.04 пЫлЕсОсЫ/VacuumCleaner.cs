namespace Домашка_от_11._04_пЫлЕсОсЫ;

//Класс обычного пылесоса
public class VacuumCleaner : Vacuum <string>
{
    public string Model => GetModel();
    public Color Color => GetColor<string>();

    public Color GetColor<T>()
    {
        return Color.Black;
    }
    public string GetModel()
    {
        return "VacuumCleaner";
    }

    public void StartCleaning(string room, int dust)
    {
        IfMaximumDust(dust);
        Console.WriteLine($"Пылесос начал уборку в зоне <{room}>");
    }

    public int MaximumDust => GetMaximumDust();

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