using DesignPattern.Behavioral.Visitor.Interfaces;
using DesignPattern.Behavioral.Visitor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
