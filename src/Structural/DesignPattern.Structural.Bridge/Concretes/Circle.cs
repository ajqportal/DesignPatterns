using DesignPattern.Structural.Bridge.Abstractions;
using DesignPattern.Structural.Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Bridge.Concretes
{
    internal class Circle : Shape
    {
        private float radius;

        public Circle(float radius, IRenderer renderer) : base(renderer)
        {
            this.radius = radius;
        }

        public override void Draw()
        {
            _renderer.RenderCircle(radius);
        }

        public override void Resize(float factor)
        {
            radius *= factor;
        }
    }
}
