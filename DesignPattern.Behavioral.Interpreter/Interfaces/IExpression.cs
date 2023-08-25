namespace DesignPattern.Behavioral.Interpreter.Interfaces
{
    internal interface IExpression
    {
        int Interpret(Dictionary<string, int> context);
    }
}
