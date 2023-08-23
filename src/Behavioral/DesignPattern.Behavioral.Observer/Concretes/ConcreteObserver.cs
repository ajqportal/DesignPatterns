using DesignPattern.Behavioral.Observer.Interfaces;

namespace DesignPattern.Behavioral.Observer.Concretes
{
    internal class ConcreteObserver : IObserver
    {
        private string _name;

        public ConcreteObserver(string name)
        {
            _name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"{_name} received: {message}");
        }
    }
}
