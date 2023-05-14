namespace Домашка_от_25._04_словари_и_транспортные_карты;

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