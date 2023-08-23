using DesignPattern.Behavioral.Memento.Enums;

namespace DesignPattern.Behavioral.Memento.Models
{
    internal class Document
    {
        public DocumentState State { get; set; }

        public Memento CreateMemento() => new Memento(State);

        public void RestoreMemento(Memento memento)
            => State = memento.State;

        public void Print()
            => Console.WriteLine($"Document state: {State}");
    }
}
