namespace Домашка_от_30._05_на_отмену_задач;

public partial class TransportCard
{
    private readonly string _userName;
    private decimal _balance;
    private decimal _minimalBalance;
    private decimal _maximalBalance;
    private static decimal _cashBack;
    
    public List<decimal> historyOfTransactions = new List<decimal>();

    public delegate void TopUpDelegate(decimal summ,
        decimal balanceAfterTopUp, decimal balanceWithCashBack);

    public delegate void PaymentDelegate(decimal payParam, decimal balanceAfterPayment);

    //можно ли оплатить 
    public Predicate<decimal> _possiblePaymentPredicate;
    
    //c помощью этой функции считаем и прибавляем кешбэк
    public Func<decimal, decimal> _calculateCashback;

    public TransportCard(string userName, 
        decimal minimalBalance,
        decimal maximalBalance, 
        decimal calculateCashback,
        decimal cashback)
    {
        _userName = userName;
        _balance = 0;
        _minimalBalance = minimalBalance;
        _maximalBalance = maximalBalance;
        _cashBack = cashback;
        _possiblePaymentPredicate = (balance) => balance > minimalBalance;
        _calculateCashback = (balance) => { return balance *= calculateCashback; };
    }

    public string UserName
    {
        get => _userName;
    }

    public decimal Balance
    {
        get => _balance;
        set => _balance = value;
    }

    public decimal MinimalBalance
    {
        get => _minimalBalance;
        set => _minimalBalance = value;
    }

    public decimal MaximalBalance
    {
        get => _maximalBalance;
        set => _maximalBalance = value;
    }

    public static decimal Cashback
    {
        get => _cashBack;
        set => _cashBack = value;
    }

    public override string ToString()
    {
        return $"Имя носителя: {UserName}, баланс: {Balance}";
    }
}