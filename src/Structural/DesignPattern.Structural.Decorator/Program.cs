// See https://aka.ms/new-console-template for more information
using DesignPattern.Structural.Decorator.Components;
using DesignPattern.Structural.Decorator.ConcreteDecorators;
using DesignPattern.Structural.Decorator.Interfaces;

ICoffee simpleCoffee = new ArabicaCoffee();
Console.WriteLine("Simple Coffee: " + simpleCoffee.GetDescription() + " - Cost: $" + simpleCoffee.GetCost());

ICoffee coffeeWithMilk = new MilkDecorator(new ArabicaCoffee());
Console.WriteLine("Coffee with Milk: " + coffeeWithMilk.GetDescription() + " - Cost: $" + coffeeWithMilk.GetCost());

ICoffee coffeeWithMilkAndSugar = new SugarDecorator(new MilkDecorator(new ArabicaCoffee()));
Console.WriteLine("Coffee with Milk and Sugar: " + coffeeWithMilkAndSugar.GetDescription() + " - Cost: $" + coffeeWithMilkAndSugar.GetCost());
