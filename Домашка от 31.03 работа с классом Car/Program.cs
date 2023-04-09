using Домашка_от_31._03_работа_с_классом_Car;

public class CarManipulations
{

    static void Main(string[] args)
    {

        Car car = new Car(CarType.Truck, 2010, CarColor.Black, 10000, FuelType.Propan, 200);


        Console.WriteLine(car.GetCarYear());
        Console.WriteLine(car.GetMileage());
        Console.WriteLine(car.GetFuelUnit());

        Console.WriteLine($"1. {car}");

        car.GoOneMile();
        car.GoOneMile();
        car.GoOneMile();

        Console.WriteLine(car.GetMileage());

        Console.WriteLine(car.GetCarYear());

        Console.WriteLine($"2. {car}");
    }
}
