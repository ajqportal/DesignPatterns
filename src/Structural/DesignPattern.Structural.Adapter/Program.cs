// See https://aka.ms/new-console-template for more information
using DesignPattern.Structural.Adapter.Adapters;
using DesignPattern.Structural.Adapter.Interfaces;
using DesignPattern.Structural.Adapter.Models;

Car car = new Car { Make = "Toyota", Model = "Camry", Year = 2022 };

IDataAdapter xmlConverter = new XmlDataAdapter();
IDataAdapter jsonConverter = new JsonDataAdapter();

string carXml = xmlConverter.ConvertData(car);
string carJson = jsonConverter.ConvertData(car);

Console.WriteLine("Car XML:");
Console.WriteLine(carXml);

Console.WriteLine("\nCar JSON:");
Console.WriteLine(carJson);
