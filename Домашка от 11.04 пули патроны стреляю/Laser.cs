namespace Домашка_от_11._04_пули_патроны_стреляю;

public class Laser : RailGunBullet
{
    public int Heat { get; }
    public int Damage { get; }
    
    public Laser()
    {
        Heat   = 30;
        Damage = 50;
    }
}