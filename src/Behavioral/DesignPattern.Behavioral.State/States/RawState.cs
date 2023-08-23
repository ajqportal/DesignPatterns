using DesignPattern.Behavioral.State.Contexts;
using DesignPattern.Behavioral.State.Interfaces;
using DesignPattern.Behavioral.State.States;

namespace DesignPattern.Behavioral.State.Context
{
    internal class RawState : IFoodState
    {
        public void Cook(Food food)
        {
            Console.WriteLine("Cooking the raw food...");
            food.SetState(new CookedState());
        }

        public void DisplayState()
        {
            Console.WriteLine("Food is raw.");
        }

        public void Eat(Food food)
        {
            Console.WriteLine("Cannot eat raw food. Cook it first.");
        }
    }
}
