namespace Домашка_от_30._05_на_отмену_задач;

public static class TransportCardExtensions
{
    // я спёр идею с супер кешбэком у Виталия, ибо мне нравится этот метод расширения, подарки это мило
    public static void AddExtraCashback(this TransportCard transportCard)
    {
        if (transportCard.Balance > 500)
        {
            transportCard.Balance += TransportCard.Cashback;
            Console.WriteLine("Поздравляю, вы получили бесплатную поездку!!!");
        }
    }
}