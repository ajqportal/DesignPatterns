using DesignPattern.Structural.Composite.Interfaces;

namespace DesignPattern.Structural.Composite.Clients
{
    // Leaf class (file)
    internal class FileClient : IFileSystemItem
    {
        private string name;

        public FileClient(string name)
        {
            this.name = name;
        }

        public void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + " " + name);
        }
    }
}
