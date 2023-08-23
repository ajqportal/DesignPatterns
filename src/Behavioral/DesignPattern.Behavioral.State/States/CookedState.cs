using DesignPattern.Behavioral.State.Contexts;
using DesignPattern.Behavioral.State.Interfaces;

namespace DesignPattern.Behavioral.State.States
{
    internal class CookedState : IFoodState
    {
        public void Cook(Food food)
        {
            Console.WriteLine("Food is already cooked.");
        }

        public void DisplayState()
        {
            Console.WriteLine("Food is cooked.");
        }

        public void Eat(Food food)
        {
            Console.WriteLine("Eating the cooked food.");
            food.SetState(new EatenState());
        }
    }
}
