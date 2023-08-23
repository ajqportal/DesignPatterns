using DesignPattern.Behavioral.Strategy.Interfaces;

namespace DesignPattern.Behavioral.Strategy.Strategies
{
    internal class MeleeAttackStrategy : IAttackStrategy
    {
        public void Attack()
        {
            Console.WriteLine("Performing melee attack!");
        }
    }
}
