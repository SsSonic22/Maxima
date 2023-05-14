namespace Домашка_от_14._04_транспортная_карта;

public class OperationEventArgs : EventArgs
{
    public decimal Summ { get; }
    
    public OperationEventArgs(decimal summ)
    {
        Summ = summ;
    }
}