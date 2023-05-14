namespace Домашка_от_11._04_пули_патроны_стреляю;

public class Spike: RailGunBullet
{
    public int Heat { get; }
    public int Damage { get; }
    
    public Spike()
    {
        Heat   = 30;
        Damage = 15;
    }
}