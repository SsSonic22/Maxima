namespace Домашка_от_14._04_транспортная_карта;

public partial class TransportCard
{
    public event EventHandler<OperationEventArgs> PaymentEvent;
    public void OnPaymentEvent(decimal summ)
    {
        PaymentEvent?.Invoke(this, new OperationEventArgs(summ));
    }
    public void Payment(decimal summ, Predicate<decimal> possibleDebit)
    {
        _possibleDebit = possibleDebit;
        decimal cashBack = _calculateCashBack(summ);
        if (_possibleDebit(summ))
        {
            Balance -= summ;
            Balance = Balance + cashBack;
            History.Add(new Operation(){Name = Operation.OperatioEnum.Payment, Summ = summ});
            if (cashBack > 0)
            {
                History.Add(new Operation() { Name = Operation.OperatioEnum.CashBack, Summ = cashBack });
                _notify($"Начислен кэшбэк в размере {cashBack} рублей");
            }
            OnPaymentEvent(summ);
        }
        else
        {
            throw new Exception("Not enough cash");
        }
    }
}