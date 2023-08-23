// See https://aka.ms/new-console-template for more information
using DesignPattern.Behavioral.Iterator.Aggregate;
using DesignPattern.Behavioral.Iterator.Interfaces;
using DesignPattern.Behavioral.Iterator.Models;

CarCollection carCollection = new CarCollection();
carCollection.AddCar(new Car("Toyota", "Camry"));
carCollection.AddCar(new Car("Honda", "Accord"));
carCollection.AddCar(new Car("Ford", "Mustang"));

IIterator iterator = carCollection.CreateIterator();

Console.WriteLine("Car Collection:");
while (iterator.HasNext())
{
    Car car = iterator.CurrentCar();
    Console.WriteLine($"{car.Make} {car.Model}");
    iterator.Next();
}