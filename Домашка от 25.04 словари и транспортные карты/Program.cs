namespace Домашка_от_25._04_словари_и_транспортные_карты;

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
        var bus1 = new Transport(903, "Yaroslavskiy");
        var bus2 = new Transport(76, "Yaroslavskiy");
        var bus3 = new Transport(9, "Khamovniki");
        var bus4 = new Transport(11, "Lubyanka");


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
        myCard.SetTheRoute(bus1, myCard);
        myCard.Payment(25, 
            summ =>
            {
                if (summ > myCard.Balance)
                    return false;
                return true;
            });
        myCard.SetTheRoute(bus2, myCard);
        myCard.Payment(150, 
            summ =>
            {
                if (summ > myCard.Balance)
                    return false;
                return true;
            });
        myCard.SetTheRoute(bus3, myCard);
        myCard.Payment(70, 
            summ =>
            {
                if (summ > myCard.Balance)
                    return false;
                return true;
            });
        myCard.SetTheRoute(bus4, myCard);
        myCard.Payment(60, 
            summ =>
            {
                if (summ > myCard.Balance)
                    return false;
                return true;
            });
        myCard.SetTheRoute(bus1, myCard);
        myCard.GetHistory();
        Console.WriteLine($"Ваш баланс: {myCard.NewBalance.Pop()}");

        myCard.IsTheBusUsed(bus3);
        myCard.TopUpEvent -= myCardOnTopUpEvent(myCard);
        myCard.PaymentEvent -= myCardOnPaymentEvent(myCard);
        myCard.ArrestTransportCard();
        
        ShowCashBack(myCard);
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