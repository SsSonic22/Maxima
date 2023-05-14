namespace Домашка_от_11._04_пули_патроны_стреляю;

public class RailGun 
{
    private int _heat;

    public int Shot<T>() where T : RailGunBullet, new()
    {
        T bullet = new T();
        _heat += bullet.Heat;

        if (_heat > 100)
        {
            _heat = 0;
            throw new OverheatException("Railgun overheated");
        }

        return bullet.Damage;
    }
}