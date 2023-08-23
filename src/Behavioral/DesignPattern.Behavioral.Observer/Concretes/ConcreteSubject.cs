using DesignPattern.Behavioral.Observer.Interfaces;

namespace DesignPattern.Behavioral.Observer.Concretes
{
    internal class ConcreteSubject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string _state;

        public void NotifyObservers(string message)
        {
            foreach (var observer in observers)
            {
                observer.Update(message);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void ChangeState(string newState)
        {
            _state = newState;
            NotifyObservers($"State changed to {_state}");
        }
    }
}
