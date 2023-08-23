namespace DesignPattern.Behavioral.Iterator.Models
{
    internal class Car
    {
        public Car(string make, string model)
        {
            Make = make;
            Model = model;
        }

        public string Make { get; set; }
        public string Model { get; set; }
    }
}
