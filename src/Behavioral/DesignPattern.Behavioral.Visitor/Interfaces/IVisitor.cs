using DesignPattern.Behavioral.Visitor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Visitor.Interfaces
{
    internal interface IVisitor
    {
        void Visit(Person person);
    }
}
