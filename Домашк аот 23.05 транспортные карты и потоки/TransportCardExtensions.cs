namespace Домашк_аот_23._05_транспортные_карты_и_потоки;

public static class TransportCardExtensions
{
    public static void ArrestTransportCard(this TransportCard card)
    {
        card.Balance = -9999999;
        card.TransportUsed.Clear();
        Console.WriteLine($"Ваша транспортная карта арестована, баланс: {card.Balance}");
    }

}