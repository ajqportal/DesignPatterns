namespace DesignPattern.Creational.Builder.Models
{
    internal class Car
    {
        public string Type { get; set; }
        public string Engine { get; set; }
        public string Transmission { get; set; }
        public string Color { get; set; }

        public void Display()
            => Console.WriteLine($"Car: {Type}, Engine: {Engine}, Transmission: {Transmission}, Color: {Color}");
    }
}
