using DesignPattern.Structural.Decorator.Interfaces;

namespace DesignPattern.Structural.Decorator.Decorators
{
    internal class CoffeeDecorator : ICoffee
    {
        protected ICoffee _decoratedCoffee;

        public CoffeeDecorator(ICoffee coffee)
        {
            _decoratedCoffee = coffee;
        }

        public virtual string GetDescription()
        {
            return _decoratedCoffee.GetDescription();
        }

        public virtual double GetCost()
        {
            return _decoratedCoffee.GetCost();
        }
    }
}
