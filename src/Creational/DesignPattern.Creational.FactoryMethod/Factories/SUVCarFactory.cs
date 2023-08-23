using DesignPattern.Creational.FactoryMethod.Abstractions;
using DesignPattern.Creational.FactoryMethod.Concretes;
using DesignPattern.Creational.FactoryMethod.Interfaces;

namespace DesignPattern.Creational.FactoryMethod.Factories
{
    internal class SUVCarFactory : CarFactory
    {
        public override ICar CreateCar()
        {
            return new SUVCar();
        }
    }
}
