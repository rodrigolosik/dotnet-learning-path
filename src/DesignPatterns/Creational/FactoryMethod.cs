namespace DesignPatterns.Creational.FactoryMethod;

public interface ITransportation
{
    void Travel();
}

public class Car : ITransportation
{
    public void Travel()
    {
        Console.WriteLine("Traveling by car");
    }
}

public class Bike : ITransportation
{
    public void Travel()
    {
        Console.WriteLine("Traveling by bike");
    }
}

public abstract class TransportationFactory
{
    public abstract ITransportation CreateTransportation();
}

public class CarFactory : TransportationFactory
{
    public override ITransportation CreateTransportation()
    {
        return new Car();
    }
}

public class BikeFactory : TransportationFactory
{
    public override ITransportation CreateTransportation()
    {
        return new Bike();
    }
}