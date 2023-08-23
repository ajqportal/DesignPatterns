using DesignPattern.Creational.AbstractFactory.Concretes.Engines;
using DesignPattern.Creational.AbstractFactory.Concretes.Interiors;
using DesignPattern.Creational.AbstractFactory.Interfaces;

namespace DesignPattern.Creational.AbstractFactory.Factories
{
    internal class ElectricCarFactory : ICarFactory
    {
        public IEngine CreateEngine()
        {
            return new ElectricEngine();
        }

        public IInterior CreateInterior()
        {
            return new ClothInterior();
        }
    }
}
