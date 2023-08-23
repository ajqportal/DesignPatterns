// See https://aka.ms/new-console-template for more information
using DesignPattern.Creational.Builder.Builders;
using DesignPattern.Creational.Builder.Clients;
using DesignPattern.Creational.Builder.Interfaces;
using DesignPattern.Creational.Builder.Models;

CarClient client = new CarClient();

ICarBuilder sedanBuilder = new SedanCarBuilder();
client.BuildCar(sedanBuilder);
Car sedan = sedanBuilder.GetCar();
sedan.Display();

ICarBuilder suvBuilder = new JeepneyCarBuilder();
client.BuildCar(suvBuilder);
Car suv = suvBuilder.GetCar();
suv.Display();
