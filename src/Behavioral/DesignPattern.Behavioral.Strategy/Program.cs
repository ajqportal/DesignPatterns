// See https://aka.ms/new-console-template for more information
using DesignPattern.Behavioral.Strategy.Contexts;
using DesignPattern.Behavioral.Strategy.Strategies;

Soldier soldier = new Soldier(new MeleeAttackStrategy());

soldier.Attack(); // Output: Performing melee attack!

soldier.SetAttackStrategy(new RangedAttackStrategy());
soldier.Attack(); // Output: Performing ranged attack!

soldier.SetAttackStrategy(new TacticalNukeAttackStrategy());
soldier.Attack(); // Output: Launching a tactical nuke attack!
