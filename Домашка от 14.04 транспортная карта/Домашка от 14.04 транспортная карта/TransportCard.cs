namespace Домашка_от_14._04_транспортная_карта;

class TransportCard
{
    public decimal Balance { get; set; }
    public List <Operation> History { get; set; }
    private readonly Func<decimal, decimal> _calculateCashBack;
    private Predicate<decimal> _possibleDebit;
    private Action<string> _notify;
    public TransportCard(Action<string> notify, Func<decimal, decimal> calculateCashBack)
    {
        _notify = notify;
        _calculateCashBack = calculateCashBack;
    }
    public void TopUp(decimal summ)
    {
        Balance += summ;
        _notify($"Пополнено на {summ} рублей, текущий баланс: {Balance} рублей");
        History.Add(new Operation(){Name = Operation.OperatioEnum.TopUp, Summ = summ});
    }
    
    public void Payment(decimal summ, Predicate<decimal> possibleDebit)
    {
        _possibleDebit = possibleDebit;
        decimal cashBack = _calculateCashBack(summ);
        if (_possibleDebit(summ))
        {
            Balance -= summ;
            Balance = Balance + cashBack;
            _notify($"Списано {summ} рублей, текущий баланс: {Balance} рублей");
            History.Add(new Operation(){Name = Operation.OperatioEnum.Payment, Summ = summ});
            if (cashBack > 0)
                History.Add(new Operation(){Name = Operation.OperatioEnum.CashBack, Summ = cashBack});
        }
        else
        {
            throw new Exception("Not enough cash");
        }
    }

    public void GetHistory()
    {
        foreach (Operation operation in History)
        {
            Console.WriteLine(operation);
        }
    }
}