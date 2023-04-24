// See https://aka.ms/new-console-template for more information

using Домашка_от_14._04_транспортная_карта;

class Program
{
    static void Main()
    {
        EventHandler<OperationEventArgs> myCardOnPaymentEvent(TransportCard myCard1)
        {
            return (sended, eventArgs) =>
            {
                Console.WriteLine($"Списано {eventArgs.Summ} рублей, текущий баланс: {myCard1.Balance} рублей");;
            };
        }

        EventHandler<OperationEventArgs> myCardOnTopUpEvent(TransportCard transportCard)
        {
            return (sended, eventArgs) =>
            {
                Console.WriteLine($"Пополнено на {eventArgs.Summ} рублей, текущий баланс: {transportCard.Balance} рублей");;
            };
        }

        var myCard = new TransportCard(s => Console.WriteLine(s), CashBack);

        myCard.TopUpEvent += myCardOnTopUpEvent(myCard);
        myCard.PaymentEvent += myCardOnPaymentEvent(myCard);
        
        myCard.TopUp(1000);
        myCard.Payment(55, 
            summ =>
            {
                if (summ > myCard.Balance)
                    return false;
                return true;
            });
        myCard.Payment(25, 
            summ =>
            {
                if (summ > myCard.Balance)
                    return false;
                return true;
            });
        myCard.Payment(150, 
            summ =>
            {
                if (summ > myCard.Balance)
                    return false;
                return true;
            });
        myCard.Payment(70, 
            summ =>
            {
                if (summ > myCard.Balance)
                    return false;
                return true;
            });
        myCard.Payment(60, 
            summ =>
            {
                if (summ > myCard.Balance)
                    return false;
                return true;
            });
        myCard.GetHistory();
        Console.WriteLine($"Ваш баланс: {myCard.NewBalance.Pop()}");
        
        myCard.TopUpEvent -= myCardOnTopUpEvent(myCard);
        myCard.PaymentEvent -= myCardOnPaymentEvent(myCard);
        ShowCashBack(myCard);
        myCard.ArrestTransportCard();
    }

    public static decimal CashBack(decimal summ)
    {
        var cashBack = 0;
        if (summ > 50 && summ < 100)
            return cashBack = 5;
        if (summ > 100)
            return cashBack = 10;
        return cashBack;
    }

    public static void ShowCashBack(TransportCard myCard)
    {
        var cashBack = myCard.History.Where(op => op.Name == Operation.OperatioEnum.CashBack);
        decimal cashBackCount = cashBack.Count();
        decimal cashBackSumm = cashBack.Sum(csh => csh.Summ);
        
        Console.WriteLine($"Кешбэк был начислен {cashBackCount} раз, общая сумма кешбэка {cashBackSumm}");
    }
}