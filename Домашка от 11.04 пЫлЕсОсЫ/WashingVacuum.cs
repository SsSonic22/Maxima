namespace Домашка_от_11._04_пЫлЕсОсЫ;

//Моющий пылесос
public class WashingVacuum : Vacuum <byte>
{
    public string Model => GetModel();

    public string GetModel()
    {
        return "WashingVacuum";
    }
    public Color Color => GetColor<byte>();

    public Color GetColor<T>()
    {
        return Color.Blue;
    }
    public void StartCleaning(string room, int dust)
    {
        IfMaximumDust(dust);
        Console.WriteLine($"Моющий пылесос начал уборку в зоне <{room}>");
    }
    public int MaximumDust => GetMaximumDust();

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