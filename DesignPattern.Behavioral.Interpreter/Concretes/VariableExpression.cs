using DesignPattern.Behavioral.Interpreter.Interfaces;

namespace DesignPattern.Behavioral.Interpreter.Concretes
{
    internal class VariableExpression : IExpression
    {
        private string _name;

        public VariableExpression(string name)
        {
            _name = name;
        }

        public int Interpret(Dictionary<string, int> context)
        {
            if (context.ContainsKey(_name))
            {
                return context[_name];
            }
            return 0; // Default value for undefined variables
        }
    }
}
