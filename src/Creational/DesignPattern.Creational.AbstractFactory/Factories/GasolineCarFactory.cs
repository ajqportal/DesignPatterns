using DesignPattern.Creational.AbstractFactory.Concretes.Engines;
using DesignPattern.Creational.AbstractFactory.Concretes.Interiors;
using DesignPattern.Creational.AbstractFactory.Interfaces;

namespace DesignPattern.Creational.AbstractFactory.Factories
{
    internal class GasolineCarFactory : ICarFactory
    {
        public IEngine CreateEngine()
        {
            return new GasolineEngine();
        }

        public IInterior CreateInterior()
        {
            return new LeatherInterior();
        }
    }
}
