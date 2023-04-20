namespace Домашка_от_11._04_пЫлЕсОсЫ;

//Пылесос мини
public class VacuumMini : Vacuum<int>
{
    public string Model => GetModel();
    
    public string GetModel()
    {
        return "VacuumMini";
    }
    public Color Color => GetColor<int>();

    public Color GetColor<T>()
    {
        return Color.Pink;
    }
    public void StartCleaning(string room, int dust)
    {
        IfMaximumDust(dust);
        Console.WriteLine($"Пылесос мини начал уборку в зоне <{room}>");
    }
    public int MaximumDust => GetMaximumDust();

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