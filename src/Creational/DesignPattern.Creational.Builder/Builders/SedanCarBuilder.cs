using DesignPattern.Creational.Builder.Interfaces;
using DesignPattern.Creational.Builder.Models;

namespace DesignPattern.Creational.Builder.Builders
{
    internal class SedanCarBuilder : ICarBuilder
    {
        private Car car = new Car();

        public void SetType()
        {
            car.Type = "Sedan";
        }

        public void SetEngine()
        {
            car.Engine = "V6";
        }

        public void SetTransmission()
        {
            car.Transmission = "Automatic";
        }

        public void SetColor()
        {
            car.Color = "Black";
        }

        public Car GetCar()
        {
            return car;
        }
    }
}
