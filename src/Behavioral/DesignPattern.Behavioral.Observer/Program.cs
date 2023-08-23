// See https://aka.ms/new-console-template for more information
using DesignPattern.Behavioral.Observer.Concretes;

ConcreteSubject subject = new ConcreteSubject();

ConcreteObserver observerA = new ConcreteObserver("Observer A");
ConcreteObserver observerB = new ConcreteObserver("Observer B");

subject.RegisterObserver(observerA);
subject.RegisterObserver(observerB);

subject.ChangeState("State 1");
subject.ChangeState("State 2");

subject.RemoveObserver(observerB);

subject.ChangeState("State 3");
