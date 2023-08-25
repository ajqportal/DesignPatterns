using DesignPattern.Structural.Proxy.Interfaces;

namespace DesignPattern.Structural.Proxy.Subjects
{
    internal class RealImage : IImage
    {
        private string _filename;

        public RealImage(string filename)
        {
            this._filename = filename;
            LoadFromDisk();
        }

        private void LoadFromDisk()
        {
            Console.WriteLine($"Loading image: {_filename}");
        }

        public void Display()
        {
            Console.WriteLine($"Displaying image: {_filename}");
        }
    }
}
