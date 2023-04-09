namespace MaximaHomeWorkTheSix
{
    public class Car
    {
        public enum CarColor
        {
            Blue, 
            Black,
            Red
        }

        public enum FuelType
        {
            Diesel,
            Propan,
            Electricity,
            Gasoline
        }
        public enum Unit
        {
            LiterPerHour,
            KbmPerHour,
            KwPerHour
            
        }
        
        private CarColor _color;
        private int      _year;
        private double   _mileage;
        private FuelType _fuel;
        private int      _fuelTankVolume;

        public Car( int year, CarColor color, double mileage, FuelType fuel, int fuelTankVolume)
        {
            _color          = color;
            _year           = year;
            _mileage        = mileage;
            _fuel           = fuel;
            _fuelTankVolume = fuelTankVolume;
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
            else 
                return Unit.LiterPerHour;
        }

    }
}