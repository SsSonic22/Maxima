namespace Домашк_аот_23._05_транспортные_карты_и_потоки;
class Program
{
    static void Main()
    {
        // EventHandler<OperationEventArgs> myCardOnPaymentEvent(TransportCard myCard1)
        // {
        //     return (sended, eventArgs) =>
        //     {
        //         Console.WriteLine($"Списано {eventArgs.Summ} рублей, текущий баланс: {myCard1.Balance} рублей");;
        //     };
        // }

        // EventHandler<OperationEventArgs> myCardOnTopUpEvent(TransportCard transportCard)
        // {
        //     return (sended, eventArgs) =>
        //     {
        //         Console.WriteLine($"Пополнено на {eventArgs.Summ} рублей, текущий баланс: {transportCard.Balance} рублей");;
        //     };
        // }

        var myCard = new TransportCard(s => Console.WriteLine(s), CashBack);
        // var bus1 = new Transport(903, "Yaroslavskiy");
        // var bus2 = new Transport(76, "Yaroslavskiy");
        // var bus3 = new Transport(9, "Khamovniki");
        // var bus4 = new Transport(11, "Lubyanka");


        // myCard.TopUpEvent += myCardOnTopUpEvent(myCard);
        // myCard.PaymentEvent += myCardOnPaymentEvent(myCard);
        
        var thread1 = new Thread(o =>
        {
            myCard.TopUp(1000);
            myCard.Payment(60, 
                summ =>
                {
                    return PossibleDebit(summ, myCard);
                });
            myCard.GetHistory();
            myCard.Payment(10, 
                summ =>
                {
                    return PossibleDebit(summ, myCard);
                });
            myCard.Payment(300, 
                summ =>
                {
                    return PossibleDebit(summ, myCard);
                });
            myCard.Payment(15, 
                summ =>
                {
                    return PossibleDebit(summ, myCard);
                });
            myCard.TopUp(500);
            myCard.GetHistory();
            Console.WriteLine($"Ваш баланс: {myCard.NewBalance.Pop()}");
        });

        var thread2 = new Thread(o =>
        {
            myCard.TopUp(1000);
            myCard.Payment(55, 
                summ =>
                {
                    return PossibleDebit(summ, myCard);
                });
            myCard.Payment(25, 
                summ =>
                {
                    return PossibleDebit(summ, myCard);
                });
            myCard.Payment(150, 
                summ =>
                {
                    return PossibleDebit(summ, myCard);
                });
            myCard.Payment(70, 
                summ =>
                {
                    return PossibleDebit(summ, myCard);
                });
            myCard.GetHistory();
            myCard.Payment(60, 
                summ =>
                {
                    return PossibleDebit(summ, myCard);
                });

            myCard.GetHistory();
            Console.WriteLine($"Ваш баланс: {myCard.NewBalance.Pop()}");
        });
        
        thread1.Start();
        thread2.Start();
        
        // myCard.TopUp(1000);
        // myCard.Payment(55, 
        //     summ =>
        //     {
        //         if (summ > myCard.Balance)
        //             return false;
        //         return true;
        //     });
        // myCard.SetTheRoute(bus1, myCard);
        // myCard.Payment(25, 
        //     summ =>
        //     {
        //         if (summ > myCard.Balance)
        //             return false;
        //         return true;
        //     });
        // myCard.SetTheRoute(bus2, myCard);
        // myCard.Payment(150, 
        //     summ =>
        //     {
        //         if (summ > myCard.Balance)
        //             return false;
        //         return true;
        //     });
        // myCard.SetTheRoute(bus3, myCard);
        // myCard.Payment(70, 
        //     summ =>
        //     {
        //         if (summ > myCard.Balance)
        //             return false;
        //         return true;
        //     });
        // myCard.SetTheRoute(bus4, myCard);
        // myCard.Payment(60, 
        //     summ =>
        //     {
        //         if (summ > myCard.Balance)
        //             return false;
        //         return true;
        //     });
        // myCard.SetTheRoute(bus1, myCard);
        // myCard.GetHistory();
        // Console.WriteLine($"Ваш баланс: {myCard.NewBalance.Pop()}");

        //myCard.IsTheBusUsed(bus3);
        // myCard.TopUpEvent -= myCardOnTopUpEvent(myCard);
        // myCard.PaymentEvent -= myCardOnPaymentEvent(myCard);
        //myCard.ArrestTransportCard();
        
        // ShowCashBack(myCard);
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

    public static void ShowCashBack(TransportCard card)
    {
        var cashBack = card.History.Where(op => op.Name == Operation.OperatioType.CashBack);
        decimal cashBackCount = cashBack.Count();
        decimal cashBackSumm = cashBack.Sum(csh => csh.Summ);
        
        Console.WriteLine($"Кешбэк был начислен {cashBackCount} раз, общая сумма кешбэка {cashBackSumm}");
    }

    public static bool PossibleDebit(decimal summ, TransportCard card)
    {
        if (summ > card.Balance)
            return false;
        return true;
    }
}