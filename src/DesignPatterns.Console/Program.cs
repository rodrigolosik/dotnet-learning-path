using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Creational.FactoryMethod;

TransportationFactory carFactory = new CarFactory();
ITransportation car = carFactory.CreateTransportation();
car.Travel();

TransportationFactory bikeFactory = new BikeFactory();
ITransportation bike = bikeFactory.CreateTransportation();
bike.Travel();


HairCut hairCut = new HairCut();
hairCut.SetHairCut(new FlatTop());
hairCut.DoHairCut();

hairCut.SetHairCut(new Caesar());
hairCut.DoHairCut();    