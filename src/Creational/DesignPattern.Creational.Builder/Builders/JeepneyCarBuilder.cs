using DesignPattern.Creational.Builder.Interfaces;
using DesignPattern.Creational.Builder.Models;

namespace DesignPattern.Creational.Builder.Builders
{
    internal class JeepneyCarBuilder : ICarBuilder
    {
        private Car car = new Car();

        public void SetType()
        {
            car.Type = "SUV";
        }

        public void SetEngine()
        {
            car.Engine = "V8";
        }

        public void SetTransmission()
        {
            car.Transmission = "Manual";
        }

        public void SetColor()
        {
            car.Color = "Silver";
        }

        public Car GetCar()
        {
            return car;
        }
    }
}
