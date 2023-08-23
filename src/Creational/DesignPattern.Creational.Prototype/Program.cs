// See https://aka.ms/new-console-template for more information
using DesignPattern.Creational.Prototype.Concretes;

Airplane originalAirplane = new Airplane("Boeing 747", 900);

Airplane clonedAirplane = (Airplane)originalAirplane.Clone();
clonedAirplane.Model = "Airbus A380";

originalAirplane.Fly(); 
clonedAirplane.Fly();  
