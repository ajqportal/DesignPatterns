using DesignPattern.Behavioral.Strategy.Interfaces;

namespace DesignPattern.Behavioral.Strategy.Contexts
{
    internal class Soldier
    {
        private IAttackStrategy _attackStrategy;

        public Soldier(IAttackStrategy attackStrategy)
        {
            _attackStrategy = attackStrategy;
        }

        public void SetAttackStrategy(IAttackStrategy strategy)
            => _attackStrategy = strategy;

        public void Attack()
            => _attackStrategy.Attack();
    }
}
