namespace Домашка_от_25._04_словари_и_транспортные_карты;

public class OperationEventArgs : EventArgs
{
    public decimal Summ { get; }
    
    public OperationEventArgs(decimal summ)
    {
        Summ = summ;
    }
}