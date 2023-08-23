using DesignPattern.Behavioral.State.Context;
using DesignPattern.Behavioral.State.Interfaces;

namespace DesignPattern.Behavioral.State.Contexts
{
    internal class Food
    {
        private IFoodState _currentFoodState;

        internal Food()
        {
            _currentFoodState = new RawState();
        }

        public void SetState(IFoodState state)
            => _currentFoodState = state;

        public void CheckState()
            => _currentFoodState.DisplayState();

        public void Cook()
            => _currentFoodState.Cook(this);

        public void Eat()
            => _currentFoodState.Eat(this);
    }
}
