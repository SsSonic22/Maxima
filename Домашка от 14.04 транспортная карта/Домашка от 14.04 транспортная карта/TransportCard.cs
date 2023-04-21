namespace Домашка_от_14._04_транспортная_карта;

class TransportCard
{
    public decimal Balance { get; set; }
    public List<Operation> History;
    private readonly Func<decimal, decimal> _calculateCashBack;
    private Predicate<decimal> _possibleDebit;
    private Action<string> _notify;
    public TransportCard(Action<string> notify, Func<decimal, decimal> calculateCashBack)
    {
        History = new List<Operation>();
        _notify = notify;
        _calculateCashBack = calculateCashBack;
    }

    public event EventHandler TopUpEvent;
    public void OnTopUpEvent()
    {
        TopUpEvent?.Invoke(this, EventArgs.Empty);
    }
    public event EventHandler PaymentEvent;
    public void OnPaymentEvent()
    {
        PaymentEvent?.Invoke(this, EventArgs.Empty);
    }
    public void TopUp(decimal summ)
    {
        Balance += summ;
        _notify($"Пополнено на {summ} рублей");
        History.Add(new Operation(){Name = Operation.OperatioEnum.TopUp, Summ = summ});
        OnTopUpEvent();
    }
    
    public void Payment(decimal summ, Predicate<decimal> possibleDebit)
    {
        _possibleDebit = possibleDebit;
        decimal cashBack = _calculateCashBack(summ);
        if (_possibleDebit(summ))
        {
            Balance -= summ;
            Balance = Balance + cashBack;
            _notify($"Списано {summ} рублей");
            History.Add(new Operation(){Name = Operation.OperatioEnum.Payment, Summ = summ});
            if (cashBack > 0)
                History.Add(new Operation(){Name = Operation.OperatioEnum.CashBack, Summ = cashBack});
            OnPaymentEvent();
        }
        else
        {
            throw new Exception("Not enough cash");
        }
    }

    public void GetHistory()
    {
        Console.WriteLine("История операций:");
        foreach (Operation operation in History)
        {
            Console.WriteLine($"{operation.Name} {operation.Summ}");
        }
    }
}