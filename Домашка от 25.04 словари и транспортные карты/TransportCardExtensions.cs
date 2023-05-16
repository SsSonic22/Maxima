namespace Домашка_от_25._04_словари_и_транспортные_карты;

public static class TransportCardExtensions
{
    public static void ArrestTransportCard(this TransportCard card)
    {
        card.Balance = 0;
        card.TransportUsed.Clear();
        Console.WriteLine($"Ваша транспортная карта арестована, баланс: {card.Balance}");
    }

}