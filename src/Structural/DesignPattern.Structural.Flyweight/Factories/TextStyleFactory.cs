using DesignPattern.Structural.Flyweight.Concretes;

namespace DesignPattern.Structural.Flyweight.Factories
{
    internal class TextStyleFactory
    {
        private Dictionary<string, TextStyle> _styles = new Dictionary<string, TextStyle>();

        public TextStyle GetStyle(string font, int size)
        {
            string key = $"{font}-{size}";

            if (!_styles.ContainsKey(key))
            {
                _styles[key] = new TextStyle(font, size);
            }

            return _styles[key];
        }
    }
}
