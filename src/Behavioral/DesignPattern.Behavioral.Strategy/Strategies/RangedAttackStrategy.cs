using DesignPattern.Behavioral.Strategy.Interfaces;

namespace DesignPattern.Behavioral.Strategy.Strategies
{
    internal class RangedAttackStrategy : IAttackStrategy
    {
        public void Attack()
        {
            Console.WriteLine("Performing ranged attack!");
        }
    }
}
