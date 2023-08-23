using DesignPattern.Creational.AbstractFactory.Interfaces;

namespace DesignPattern.Creational.AbstractFactory.Clients
{
    internal class CarClient
    {
        private readonly IEngine _engine;
        private readonly IInterior _interior;

        public CarClient(ICarFactory factory)
        {
            _engine = factory.CreateEngine();
            _interior = factory.CreateInterior();
        }

        public void Start() => _engine.Start();

        public void Decorate() => _interior.Decorate();
    }
}
