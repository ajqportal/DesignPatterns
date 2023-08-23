// See https://aka.ms/new-console-template for more information
using DesignPattern.Creational.AbstractFactory.Clients;
using DesignPattern.Creational.AbstractFactory.Factories;
using DesignPattern.Creational.AbstractFactory.Interfaces;

ICarFactory gasolineCarFactory = new GasolineCarFactory();
ICarFactory electricCarFactory = new ElectricCarFactory();

CarClient gasolineCar = new CarClient(gasolineCarFactory);
CarClient electricCar = new CarClient(electricCarFactory);

Console.WriteLine("Gasoline Car:");
gasolineCar.Start();
gasolineCar.Decorate();

Console.WriteLine("\nElectric Car:");
electricCar.Start();
electricCar.Decorate();
