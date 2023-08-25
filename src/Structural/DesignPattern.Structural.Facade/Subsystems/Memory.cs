namespace DesignPattern.Structural.Facade.Subsystems
{
    internal class Memory
    {
        public void Load(long position, byte[] data)
        {
            Console.WriteLine($"Memory: Loading data to position {position}");
        }
    }
}
