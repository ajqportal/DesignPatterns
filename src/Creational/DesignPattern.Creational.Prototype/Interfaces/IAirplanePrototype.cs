namespace DesignPattern.Creational.Prototype.Interfaces
{
    public interface IAirplanePrototype
    {
        IAirplanePrototype Clone();
        void Fly();
    }
}
