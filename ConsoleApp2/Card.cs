namespace ConsoleApp2;

class Card
{

    public List<decimal> History { get; set; }

    public decimal Balance { get; set; }

    // с помощью делегата
    public delegate void Notify(string message);

    //public void ConsoleNotify(Notify)

    // с помощью Action
    private Action<string> _notifyAction;

    // private Predicate<decimal> _predicate;

    //private Func<decimal, decimal> _calculateCashback;


    public Card(Action<string> notifyAction)
    {
        _notifyAction = notifyAction;
    }

    public void Add(decimal summ)
    {
        Balance += summ;
        _notifyAction($"{Balance}");

    }

    public void Pay(decimal summ)
    {
        Balance -= summ;
        _notifyAction($"{Balance}");

    }


}