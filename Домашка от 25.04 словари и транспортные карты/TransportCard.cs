namespace Домашка_от_25._04_словари_и_транспортные_карты;

public partial class TransportCard
{
    public decimal Balance { get; set; }
    public Stack<decimal> NewBalance = new Stack<decimal>();
    public Dictionary<Transport, TransportCard> TransportUsed = new Dictionary<Transport, TransportCard>();

    /// <summary>
    /// История операций (пример работы со списком)
    /// </summary>
    public List<Operation> History;
    private readonly Func<decimal, decimal> _calculateCashBack;
    private Predicate<decimal> _possibleDebit;
    private Action<string> _notify;
    /// <summary>
    /// Массив показывающий количество поездок
    /// </summary>
    public int[] Rides = new int[0];
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
        NewBalance.Push(Balance);
    }
    public void GetHistory()
    {
        Console.WriteLine("История операций:");
        foreach (Operation operation in History)
        {
            Console.WriteLine($"{operation.Name} {operation.Summ}");
        }
        //так как это транспортная карта, я делаю вывод, что каждое списание это одна поездка
        Console.WriteLine($"Общее количество поездок:{Rides.Length}");
    }

    public void SetTheRoute(Transport bus, TransportCard card)
    {
        TransportUsed.Add(bus, card);   
    }

    public void IsTheBusUsed(Transport bus)
    {
        if (TransportUsed.ContainsKey(bus))
            Console.WriteLine($"Вы пользовались автобусом №{bus.Number}");
    }
}