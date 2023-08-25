using DesignPattern.Structural.Decorator.Decorators;
using DesignPattern.Structural.Decorator.Interfaces;

namespace DesignPattern.Structural.Decorator.ConcreteDecorators
{
    internal class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Sugar";
        }

        public override double GetCost()
        {
            return base.GetCost() + 0.2;
        }
    }
}
