namespace Домашк_аот_23._05_транспортные_карты_и_потоки;

public class OperationEventArgs : EventArgs
{
    public decimal Summ { get; }
    
    public OperationEventArgs(decimal summ)
    {
        Summ = summ;
    }
}