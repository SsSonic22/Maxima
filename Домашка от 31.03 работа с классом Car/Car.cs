
using Домашка_от_31._03_работа_с_классом_Car;
public class Car
{
    private CarType  _type;
    private CarColor _color;
    private int      _year;
    private double   _mileage;
    private FuelType _fuel;
    private int      _fuelTank;

    public Car(CarType type, int year, CarColor color, double mileage, FuelType fuel, int fuelTank)
    {
        _type           = type;
        _color          = color;
        _year           = year;
        _mileage        = mileage;
        _fuel           = fuel;
        //для красоты стоят условия на минимальный объём для фуры и максимальный для спорткара
        if (_type == CarType.Truck && fuelTank < 600)
        {
            throw new Exception("The fuel tank volume is too small");
        }

        if (_type == CarType.SportCar && fuelTank > 3)
            throw new Exception("The fuel tank volume is too big");
        _fuelTank       = fuelTank;
    }

    //на тип автомобиля только гет, потому что ну нельзя наверное из легковушки сделать адекватный грузовик дальнобой
    public CarType Type => _type;
    public int TankFuel => _fuelTank;

    public CarColor Color
    {
        get
        {
            return _color;
        }
        set
        {
            _color = value;
        }
    }
    public void GoOneMile()
    {
        _mileage += 1;
    }

    public double GetMileage()
    {
        return _mileage;
    }

    public int GetCarYear()
    {
        return DateTime.Now.Year - _year;
    }

    public override string ToString()
    {
        return $"Color: {_color}, Year: {_year}, Mileage: {_mileage}";
    }

    public Unit GetFuelUnit()
    {
        if (_fuel == FuelType.Electricity)
            return Unit.KwPerHour;
        if (_fuel == FuelType.Propan)
            return Unit.KbmPerHour;
        return Unit.LiterPerHour;
    }

}