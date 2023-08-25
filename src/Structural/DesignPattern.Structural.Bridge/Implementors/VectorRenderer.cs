using DesignPattern.Structural.Bridge.Interfaces;

namespace DesignPattern.Structural.Bridge.Implementors
{
    internal class VectorRenderer : IRenderer
    {
        public void RenderCircle(float radius)
        {
            Console.WriteLine($"Drawing a circle with radius {radius} using vector renderer.");
        }

        public void RenderSquare(float side)
        {
            Console.WriteLine($"Drawing a square with side {side} using vector renderer.");
        }
    }
}
