namespace Домашка_от_11._04_пули_патроны_стреляю;

public class RailGun 
{
    private int _heat;

    public int Shot<T>() where T : RailGunBullet
    {
        _heat += RailGunBullet.Heat;
        
        if (_heat > 100)
            throw new OverheatException("Railgun overheated");
        
        return RailGunBullet.Damage;
    }
}