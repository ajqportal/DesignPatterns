using DesignPattern.Behavioral.Visitor.Interfaces;
using DesignPattern.Behavioral.Visitor.Models;

namespace DesignPattern.Behavioral.Visitor.Visitors
{
    internal class ConsoleVisitor : IVisitor
    {
        public void Visit(Person person)
        {
            Console.WriteLine($"Visitor: Hello, {person.Name}!");
        }
    }
}
