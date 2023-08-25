using DesignPattern.Structural.Flyweight.Interfaces;

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
