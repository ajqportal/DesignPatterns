using DesignPattern.Behavioral.Iterator.Interfaces;
using DesignPattern.Behavioral.Iterator.Iterators;
using DesignPattern.Behavioral.Iterator.Models;

namespace DesignPattern.Behavioral.Iterator.Aggregate
{
    internal class CarCollection : ICarCollection
    {
        private List<Car> cars = new List<Car>();

        public void AddCar(Car car) 
        { 
            cars.Add(car);
        }

        public int Count
        {
            get { return cars.Count; }
        }

        public Car this[int index]
        {
            get { return cars[index]; }
        }

        public IIterator CreateIterator()
        {
            return new CarIterator(this);
        }
    }
}
