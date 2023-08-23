// See https://aka.ms/new-console-template for more information
using DesignPattern.Creational.FactoryMethod.Abstractions;
using DesignPattern.Creational.FactoryMethod.Factories;
using DesignPattern.Creational.FactoryMethod.Interfaces;

CarFactory sedanFactory = new SedanCarFactory();
CarFactory suvFactory = new SUVCarFactory();

ICar sedanCar = sedanFactory.CreateCar();
ICar suvCar = suvFactory.CreateCar();

Console.WriteLine("Producing cars:");
sedanCar.Manufacture();
suvCar.Manufacture();
