// See https://aka.ms/new-console-template for more information
using DesignPattern.Behavioral.State.Contexts;

Food food = new Food();

food.CheckState();

food.Cook();
food.CheckState();

food.Eat();
food.CheckState();

food.Cook();
food.Eat();
