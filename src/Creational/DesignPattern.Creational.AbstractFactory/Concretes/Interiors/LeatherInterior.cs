using DesignPattern.Creational.AbstractFactory.Interfaces;

namespace DesignPattern.Creational.AbstractFactory.Concretes.Interiors
{
    internal class LeatherInterior : IInterior
    {
        public void Decorate()
        {
            Console.WriteLine("Leather interior added.");
        }
    }
}
