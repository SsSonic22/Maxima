namespace Домашка_от_30._05_на_отмену_задач;

public partial class TransportCard
{
    public event TopUpDelegate? TopUpEvent;
    public event PaymentDelegate? OnPaymentEvent;
    
    public void Payment(decimal spendingCash)
    {
        if (_possiblePaymentPredicate(_balance))
        {
            _balance -= spendingCash;
            OnPaymentEvent?.Invoke(spendingCash, _balance);
        }
        else
        {
            throw new Exception($"Недостаточно денег для оплаты проезда, " +
                                $"баланс карты составляет: " +
                                $"{_balance} рублей");
        }
        historyOfTransactions.Add(spendingCash);
    }
    
    public void TopUp (decimal summ)
    {
        if (_balance < _maximalBalance)
        {
            _balance += summ;

            if (_balance < _maximalBalance)
            {
                decimal cashbackAmount = _calculateCashback(_balance);
                _balance += cashbackAmount;

                this.AddExtraCashback();

                TopUpEvent?.Invoke(summ,
                    _balance,
                    cashbackAmount);
            }
            else
            {
                throw new Exception($"Превышен лимит" +
                                    $"максимальный разрешённый баланс на вашей карте: {_maximalBalance} рублей");
            }
        }
        else
        {
            throw new Exception($"Превышен лимит" +
                                $"баланс на данный момент {_balance} рублей");
        }
    }
    public void TopUpSubscription(decimal summ, decimal balance, decimal cashback)
    {
        Console.WriteLine($"Пополнение баланса на {summ} рублей\n" +
                          $"Начислен кешбэк в размере: {cashback} рублей\n" +
                          $"Текущий баланс: {balance} рублей\n");
    }

    public void OnPaymentSubscription(decimal summ, decimal balance)
    {
        Console.WriteLine($"-{summ} рублей\n" +
                          $"Текущий баланс: {balance} рублей\n");
    }
}