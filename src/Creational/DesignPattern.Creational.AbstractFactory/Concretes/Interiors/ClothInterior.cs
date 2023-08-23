using DesignPattern.Creational.AbstractFactory.Interfaces;

namespace DesignPattern.Creational.AbstractFactory.Concretes.Interiors
{
    internal class ClothInterior : IInterior
    {
        public void Decorate()
        {
            Console.WriteLine("Cloth interior added.");
        }
    }
}
