using DesignPattern.Creational.Builder.Interfaces;

namespace DesignPattern.Creational.Builder.Clients
{
    internal class CarClient
    {
        public void BuildCar(ICarBuilder builder)
        {
            builder.SetType();
            builder.SetEngine();
            builder.SetTransmission();
            builder.SetColor();
        }
    }
}
