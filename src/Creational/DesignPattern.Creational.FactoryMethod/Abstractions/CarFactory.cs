using DesignPattern.Creational.FactoryMethod.Interfaces;

namespace DesignPattern.Creational.FactoryMethod.Abstractions
{
    internal abstract class CarFactory
    {
        public abstract ICar CreateCar();
    }
}
