using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Bridge.Interfaces
{
    internal interface IRenderer
    {
        void RenderCircle(float radius);
        void RenderSquare(float side);
    }
}
