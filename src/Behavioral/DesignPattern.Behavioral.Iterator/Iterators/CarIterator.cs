using DesignPattern.Behavioral.Iterator.Aggregate;
using DesignPattern.Behavioral.Iterator.Interfaces;
using DesignPattern.Behavioral.Iterator.Models;

namespace DesignPattern.Behavioral.Iterator.Iterators
{
    internal class CarIterator : IIterator
    {
        private CarCollection _carCollection;
        private int current = 0; // Counter to iterator

        public CarIterator(CarCollection carCollection)
        {
            _carCollection = carCollection;
        }

        public Car CurrentCar() => _carCollection[current];

        public bool HasNext() => current < _carCollection.Count;

        public void Next() => current++;
    }
}
