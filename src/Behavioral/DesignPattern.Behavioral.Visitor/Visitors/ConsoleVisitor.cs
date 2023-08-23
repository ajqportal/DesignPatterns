using DesignPattern.Behavioral.Visitor.Interfaces;
using DesignPattern.Behavioral.Visitor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
