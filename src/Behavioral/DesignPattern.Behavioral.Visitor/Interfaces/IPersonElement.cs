using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Visitor.Interfaces
{
    internal interface IPersonElement
    {
        void Accept(IVisitor visitor);
    }
}
