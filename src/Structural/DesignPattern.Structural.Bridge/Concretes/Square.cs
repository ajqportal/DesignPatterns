using DesignPattern.Structural.Bridge.Abstractions;
using DesignPattern.Structural.Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Bridge.Concretes
{
    internal class Square : Shape
    {
        private float side;

        public Square(float side, IRenderer renderer) : base(renderer)
        {
            this.side = side;
        }

        public override void Draw()
        {
            _renderer.RenderSquare(side);
        }

        public override void Resize(float factor)
        {
            side *= factor;
        }
    }
}
