namespace Домашк_аот_23._05_транспортные_карты_и_потоки;

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