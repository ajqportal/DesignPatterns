namespace DesignPattern.Behavioral.TemplateMethod.Abstractions
{
    internal abstract class HouseTemplate
    {
        public void BuildHouse()
        {
            BuildFoundation();
            BuildWalls();
            BuildRoof();
            DecorateHouse();
            Console.WriteLine("House is built!");
        }

        protected abstract void BuildFoundation();
        protected abstract void BuildWalls();
        protected abstract void BuildRoof();
        protected abstract void DecorateHouse();
    }
}
