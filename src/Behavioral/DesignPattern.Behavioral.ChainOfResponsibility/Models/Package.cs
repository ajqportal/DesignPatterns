namespace DesignPattern.Behavioral.ChainOfResponsibility.Models
{
    internal class Package
    {
        internal Package(double weight, string destination)
        {
            Weight = weight;
            destination = Destination;
        }

        internal double Weight { get; set; }
        internal string Destination { get; set; }
    }
}
