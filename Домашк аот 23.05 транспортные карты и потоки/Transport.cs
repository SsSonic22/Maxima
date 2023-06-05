namespace Домашк_аот_23._05_транспортные_карты_и_потоки;

public class Transport
{
    public decimal Number { get; set; }
    
    public string District { get; set; }
    
    public Transport(decimal number, string district)
    {
        Number = number;
        District = district;
    }
    
}