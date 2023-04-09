namespace Домашка_от_4._04_класс_пылесос;

public abstract class Vacuum
{
    public virtual string Model { get; }

    public virtual void StartCleaning()
    {
        Console.WriteLine("Пылесос начал уборку");
    }

    public virtual void StartCleaning(string room)
    {
        Console.WriteLine($"Пылесос начал уборку в зоне <{room}>");
    }
}
