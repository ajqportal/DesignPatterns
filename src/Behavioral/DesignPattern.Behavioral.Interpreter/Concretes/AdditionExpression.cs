using DesignPattern.Behavioral.Interpreter.Interfaces;

namespace DesignPattern.Behavioral.Interpreter.Concretes
{
    internal class AdditionExpression : IExpression
    {
        private IExpression _left;
        private IExpression _right;

        public AdditionExpression(IExpression left, IExpression right)
        {
            _left = left;
            _right = right;
        }

        public int Interpret(Dictionary<string, int> context)
        {
            return _left.Interpret(context) + _right.Interpret(context);
        }
    }
}
