using DesignPattern.Structural.Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Bridge.Implementors
{
    internal class RasterRenderer : IRenderer
    {
        public void RenderCircle(float radius)
        {
            Console.WriteLine($"Drawing a circle with radius {radius} using raster renderer.");
        }

        public void RenderSquare(float side)
        {
            Console.WriteLine($"Drawing a square with side {side} using raster renderer.");
        }
    }
}
