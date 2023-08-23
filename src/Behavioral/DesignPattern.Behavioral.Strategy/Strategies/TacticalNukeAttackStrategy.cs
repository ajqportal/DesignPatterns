using DesignPattern.Behavioral.Strategy.Interfaces;

namespace DesignPattern.Behavioral.Strategy.Strategies
{
    internal class TacticalNukeAttackStrategy : IAttackStrategy
    {
        public void Attack()
        {
            Console.WriteLine("Launching a tactical nuke attack!");
        }
    }
}
