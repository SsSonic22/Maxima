namespace Домашка_от_11._04_пЫлЕсОсЫ;

public class Vacuum <T> 
{
    public virtual string Model { get; }

    public void StartCleaning(string room, int dust)
    {
        Console.WriteLine($"Пылесос начал уборку в зоне <{room}>");
    }

    public virtual int MaximumDust { get;}
}