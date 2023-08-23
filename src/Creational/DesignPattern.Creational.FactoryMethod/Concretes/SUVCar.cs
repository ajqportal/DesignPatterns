using DesignPattern.Creational.FactoryMethod.Interfaces;

namespace DesignPattern.Creational.FactoryMethod.Concretes
{
    internal class SUVCar : ICar
    {
        public void Manufacture()
        {
            Console.WriteLine("Manufacturing an SUV car.");
        }
    }
}
