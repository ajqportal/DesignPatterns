using DesignPattern.Structural.Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Decorator.Components
{
    internal class ArabicaCoffee : ICoffee
    {
        public string GetDescription()
        {
            return "Simple Arabica Coffee";
        }

        public double GetCost()
        {
            return 2.0;
        }
    }
}
