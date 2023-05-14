namespace Домашка_от_11._04_пули_патроны_стреляю;

public class Program
{
    
    public static void TestRifle<T>(RailGun railgun) where T : RailGunBullet, new()
    {
        int shotCount = 0;
        int finalDamage = 0;
        try
        {
            while (true)
            {
                int damage = railgun.Shot<T>();
                shotCount++;
                finalDamage += damage;
            }
        }
        catch (OverheatException e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine($"Damage dealt: {finalDamage}");
            Console.WriteLine($"Total shot count : {shotCount}");
            
        }
    }
    static void Main()
    {
        var RailGun = new RailGun();

        TestRifle<Laser>(RailGun);
        TestRifle<Spike>(RailGun);
        TestRifle<Plasma>(RailGun);
    }
}
