namespace Домашка_от_11._04_пули_патроны_стреляю;

public class Plasma : RailGunBullet
{
    public int Heat { get; }
    public int Damage { get; }

    public Plasma()
    {
        Heat   = 25;
        Damage = 30;
    }
}
