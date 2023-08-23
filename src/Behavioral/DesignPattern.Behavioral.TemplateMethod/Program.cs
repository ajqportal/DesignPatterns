// See https://aka.ms/new-console-template for more information
using DesignPattern.Behavioral.TemplateMethod.Abstractions;
using DesignPattern.Behavioral.TemplateMethod.Concretes;

HouseTemplate concreteHouse = new ConcreteHouse();
HouseTemplate woodenHouse = new WoodenHouse();

Console.WriteLine("Building a concrete house:");
concreteHouse.BuildHouse();

Console.WriteLine("\nBuilding a wooden house:");
woodenHouse.BuildHouse();
