using DesignPattern.Behavioral.Visitor.Interfaces;
using DesignPattern.Behavioral.Visitor.Models;

namespace DesignPattern.Behavioral.Visitor.Visitors
{
    internal class EmailVisitor : IVisitor
    {
        public void Visit(Person person)
        {
            Console.WriteLine($"Email sent to {person.Name}.");
        }
    }
}
