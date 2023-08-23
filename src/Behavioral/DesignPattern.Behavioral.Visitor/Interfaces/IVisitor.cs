using DesignPattern.Behavioral.Visitor.Models;

namespace DesignPattern.Behavioral.Visitor.Interfaces
{
    internal interface IVisitor
    {
        void Visit(Person person);
    }
}
