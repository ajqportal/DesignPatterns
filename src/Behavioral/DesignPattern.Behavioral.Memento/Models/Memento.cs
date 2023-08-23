using DesignPattern.Behavioral.Memento.Enums;

namespace DesignPattern.Behavioral.Memento.Models
{
    internal class Memento
    {
        internal DocumentState State { get; private set; }

        internal Memento(DocumentState state)
        {
            State = state;    
        }
    }
}
