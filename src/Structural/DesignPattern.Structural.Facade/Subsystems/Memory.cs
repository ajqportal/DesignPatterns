using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
