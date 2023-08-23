using DesignPattern.Creational.Builder.Models;

namespace DesignPattern.Creational.Builder.Interfaces
{
    internal interface ICarBuilder
    {
        void SetType();
        void SetEngine();
        void SetTransmission();
        void SetColor();
        Car GetCar();
    }
}
