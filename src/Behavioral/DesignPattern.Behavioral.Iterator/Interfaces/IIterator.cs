using DesignPattern.Behavioral.Iterator.Models;

namespace DesignPattern.Behavioral.Iterator.Interfaces
{
    internal interface IIterator
    {
        Car CurrentCar();
        bool HasNext();
        void Next();
    }
}
