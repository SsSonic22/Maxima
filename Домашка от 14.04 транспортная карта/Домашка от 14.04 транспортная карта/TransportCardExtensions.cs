namespace Домашка_от_14._04_транспортная_карта;

public static class TransportCardExtensions
{
    public static void ArrestTransportCard(this TransportCard card)
    {
        card.Balance = 0;
        Console.WriteLine($"Ваша транспортная карта арестована, баланс: {card.Balance}");
    }

}