namespace Домашк_аот_23._05_транспортные_карты_и_потоки;

public class Operation
{
    public OperatioType Name;

    public decimal Summ;
    public enum OperatioType
    {
        TopUp,
        Payment,
        CashBack
    }
}