namespace Домашка_от_25._04_словари_и_транспортные_карты;

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