using DesignPatterns.Creational.FactoryMethod;

TransportationFactory carFactory = new CarFactory();
ITransportation car = carFactory.CreateTransportation();
car.Travel();

TransportationFactory bikeFactory = new BikeFactory();
ITransportation bike = bikeFactory.CreateTransportation();
bike.Travel();