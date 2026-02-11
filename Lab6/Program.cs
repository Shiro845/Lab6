List<Vehicle> vehicles = new List<Vehicle>
    {
        new Car("Mercedes", 90),
        new Bicycle("Canyon", 15),
        new Airplane("Boeing", 900)
    };

foreach (var vehicle in vehicles)
{
    vehicle.Move();
}

public abstract class Vehicle
{
    protected string? Brand;
    protected int Speed;

    public Vehicle(string brand,  int speed)
    {
        Brand = brand;
        Speed = speed;
    }
    public abstract void Move();
}

public class Car : Vehicle
{
    public Car(string brand, int speed) : base(brand, speed) { }
    public override void Move()
    {
        Console.WriteLine($"Автомобіль марки {Brand} їде зі швидкістю {Speed} км/год");
    }
}

public class Bicycle : Vehicle
{
    public Bicycle(string brand, int speed) : base(brand, speed) { }
    public override void Move()
    {
        Console.WriteLine($"Велосипед марки {Brand} їде зі швидкістю {Speed} км/год");
    }
}

public class Airplane : Vehicle
{
    public Airplane(string brand, int speed) : base(brand, speed) { }
    public override void Move()
    {
        Console.WriteLine($"Літак марки {Brand} летить зі швидкістю {Speed} км/год");
    }
}