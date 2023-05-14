namespace Домашка_от_14._04_транспортная_карта;

public class Operation
{
    public OperatioEnum Name;

    public decimal Summ;
    public enum OperatioEnum
    {
        TopUp,
        Payment,
        CashBack
    }
}