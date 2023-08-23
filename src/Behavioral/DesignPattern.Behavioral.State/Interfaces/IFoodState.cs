using DesignPattern.Behavioral.State.Contexts;

namespace DesignPattern.Behavioral.State.Interfaces
{
    internal interface IFoodState
    {
        void DisplayState();
        void Cook(Food food);
        void Eat(Food food);
    }
}
