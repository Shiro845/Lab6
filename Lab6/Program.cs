List<Vehicle> vehicles = new List<Vehicle>
    {
        new Car(),
        new Bicycle(),
        new Airplane()
    };

foreach (var vehicle in vehicles)
{
    vehicle.Move();
}

public abstract class Vehicle
{
    protected string? Brand;
    protected int Speed;
    public abstract void Move();
}

public class Car : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Автомобіль їздить");
    }
}

public class Bicycle : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Велосипед їздить");
    }
}

public class Airplane : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Літак летить");
    }
}