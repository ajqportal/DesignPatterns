using DesignPattern.Structural.Composite.Interfaces;

namespace DesignPattern.Structural.Composite.Clients
{
    // Composite
    internal class DirectoryClient : IFileSystemItem
    {
        private string name;
        private List<IFileSystemItem> items = new List<IFileSystemItem>();

        public DirectoryClient(string name)
        {
            this.name = name;
        }

        public void AddItem(IFileSystemItem item)
        {
            items.Add(item);
        }

        public void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + "+ " + name);

            foreach (var item in items)
            {
                item.Display(depth + 2);
            }
        }
    }
}
