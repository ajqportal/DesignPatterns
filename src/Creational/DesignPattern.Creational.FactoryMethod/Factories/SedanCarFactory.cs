using DesignPattern.Creational.FactoryMethod.Abstractions;
using DesignPattern.Creational.FactoryMethod.Concretes;
using DesignPattern.Creational.FactoryMethod.Interfaces;

namespace DesignPattern.Creational.FactoryMethod.Factories
{
    internal class SedanCarFactory : CarFactory
    {
        public override ICar CreateCar()
        {
            return new SedanCar();
        }
    }
}
