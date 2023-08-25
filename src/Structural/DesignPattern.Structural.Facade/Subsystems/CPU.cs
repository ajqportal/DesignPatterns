namespace DesignPattern.Structural.Facade.Subsystems
{
    internal class CPU
    {
        public void Freeze()
        {
            Console.WriteLine("CPU: Freezing...");
        }

        public void Jump(long position)
        {
            Console.WriteLine($"CPU: Jumping to position {position}");
        }

        public void Execute()
        {
            Console.WriteLine("CPU: Executing commands...");
        }
    }
}
