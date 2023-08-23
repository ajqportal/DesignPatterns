using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Decorator.Interfaces
{
    internal interface ICoffee
    {
        string GetDescription();
        double GetCost();
    }
}
