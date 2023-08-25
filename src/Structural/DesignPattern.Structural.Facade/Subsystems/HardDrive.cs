namespace DesignPattern.Structural.Facade.Subsystems
{
    internal class HardDrive
    {
        public byte[] Read(long sector, int size)
        {
            Console.WriteLine($"Hard Drive: Reading sector {sector} of size {size}");
            // Simulated data for demonstration
            return new byte[size];
        }
    }
}
