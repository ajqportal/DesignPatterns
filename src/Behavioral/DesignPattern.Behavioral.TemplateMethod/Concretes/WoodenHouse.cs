using DesignPattern.Behavioral.TemplateMethod.Abstractions;

namespace DesignPattern.Behavioral.TemplateMethod.Concretes
{
    internal class WoodenHouse : HouseTemplate
    {
        protected override void BuildFoundation()
        {
            Console.WriteLine("Building wooden foundation.");
        }

        protected override void BuildWalls()
        {
            Console.WriteLine("Building wooden walls.");
        }

        protected override void BuildRoof()
        {
            Console.WriteLine("Adding wooden roof.");
        }

        protected override void DecorateHouse()
        {
            Console.WriteLine("Decorating the wooden house.");
        }
    }
}
