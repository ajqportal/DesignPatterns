using DesignPattern.Creational.Prototype.Interfaces;

namespace DesignPattern.Creational.Prototype.Concretes
{
    public class Airplane : IAirplanePrototype
    {
        public string Model { get; set; }
        public int MaxSpeed { get; set; }

        public Airplane(string model, int maxSpeed)
        {
            Model = model;
            MaxSpeed = maxSpeed;
        }

        public IAirplanePrototype Clone()
        {
            return (IAirplanePrototype)MemberwiseClone(); // reflection shallow copy
        }

        public void Fly()
        {
            Console.WriteLine($"Airplane {Model} is flying at {MaxSpeed} km/h.");
        }
    }
}
