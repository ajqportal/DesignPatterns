namespace DesignPattern.Creational.AbstractFactory.Interfaces
{
    internal interface ICarFactory
    {
        IEngine CreateEngine();
        IInterior CreateInterior();
    }
}
