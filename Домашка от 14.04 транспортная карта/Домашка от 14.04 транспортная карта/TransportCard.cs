namespace Домашка_от_14._04_транспортная_карта;

public partial class TransportCard
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
    public event EventHandler<OperationEventArgs> TopUpEvent;
    public void OnTopUpEvent(decimal summ)
    {
        TopUpEvent?.Invoke(this, new OperationEventArgs(summ));
    }
    public void TopUp(decimal summ)
    {
        Balance += summ;
        History.Add(new Operation(){Name = Operation.OperatioEnum.TopUp, Summ = summ});
        OnTopUpEvent(summ);
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