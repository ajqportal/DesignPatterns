using DesignPattern.Structural.Flyweight.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Flyweight.Concretes
{
    internal class TextStyle : ITextFormatter
    {
        private string _font;
        private int _size;

        public TextStyle(string font, int size)
        {
            _font = font;
            _size = size;
        }

        public void Format(string text)
        {
            Console.WriteLine($"Formatted text: {text} with font {_font} and size {_size}");
        }
    }
}
