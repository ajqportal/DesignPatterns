using DesignPattern.Structural.Decorator.Interfaces;

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
