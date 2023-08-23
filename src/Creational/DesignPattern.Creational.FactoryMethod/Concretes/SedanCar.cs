using DesignPattern.Creational.FactoryMethod.Interfaces;

namespace DesignPattern.Creational.FactoryMethod.Concretes
{
    internal class SedanCar : ICar
    {
        public void Manufacture()
        {
            Console.WriteLine("Manufacturing a sedan car.");
        }
    }
}
