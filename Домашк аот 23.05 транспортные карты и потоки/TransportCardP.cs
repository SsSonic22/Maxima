namespace Домашк_аот_23._05_транспортные_карты_и_потоки;

public partial class TransportCard
{
    public event EventHandler<OperationEventArgs> PaymentEvent;
    public void OnPaymentEvent(decimal summ)
    {
        PaymentEvent?.Invoke(this, new OperationEventArgs(summ));
    }
    public void Payment(decimal summ, Predicate<decimal> possibleDebit)
    {
        lock (_sync)
        {
            _possibleDebit = possibleDebit;
            decimal cashBack = _calculateCashBack(summ);
            if (_possibleDebit(summ))
            {
                Balance -= summ;
                Balance = Balance + cashBack;
                History.Add(new Operation() { Name = Operation.OperatioType.Payment, Summ = summ });
                if (cashBack > 0)
                {
                    History.Add(new Operation() { Name = Operation.OperatioType.CashBack, Summ = cashBack });
                    _notify($"Начислен кэшбэк в размере {cashBack} рублей");
                }

                OnPaymentEvent(summ);
                Rides++;
                NewBalance.Push(Balance);
            }
            else
            {
                throw new Exception("Not enough cash");
            }
        }
    }
}