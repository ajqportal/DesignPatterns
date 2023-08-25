using DesignPattern.Structural.Decorator.Decorators;
using DesignPattern.Structural.Decorator.Interfaces;

namespace DesignPattern.Structural.Decorator.ConcreteDecorators
{
    internal class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Milk";
        }

        public override double GetCost()
        {
            return base.GetCost() + 0.5;
        }
    }
}
