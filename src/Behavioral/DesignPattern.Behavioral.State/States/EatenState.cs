using DesignPattern.Behavioral.State.Contexts;
using DesignPattern.Behavioral.State.Interfaces;

namespace DesignPattern.Behavioral.State.States
{
    internal class EatenState : IFoodState
    {
        public void Cook(Food food)
        {
            Console.WriteLine("Cannot cook eaten food.");
        }

        public void DisplayState()
        {
            Console.WriteLine("Food has been eaten.");
        }

        public void Eat(Food food)
        {
            Console.WriteLine("Food has already been eaten.");
        }
    }
}
