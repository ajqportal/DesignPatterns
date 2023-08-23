using DesignPattern.Behavioral.TemplateMethod.Abstractions;

namespace DesignPattern.Behavioral.TemplateMethod.Concretes
{
    internal class ConcreteHouse : HouseTemplate
    {
        protected override void BuildFoundation()
        {
            Console.WriteLine("Building concrete foundation.");
        }

        protected override void BuildWalls()
        {
            Console.WriteLine("Building concrete walls.");
        }

        protected override void BuildRoof()
        {
            Console.WriteLine("Adding concrete roof.");
        }

        protected override void DecorateHouse()
        {
            Console.WriteLine("Decorating the concrete house.");
        }
    }
}
