// See https://aka.ms/new-console-template for more information
// Define context with variable values
using DesignPattern.Behavioral.Interpreter.Concretes;
using DesignPattern.Behavioral.Interpreter.Interfaces;

Dictionary<string, int> context = new Dictionary<string, int>
{
    { "x", 10 },
    { "y", 5 }
};

// Create expressions
IExpression variableX = new VariableExpression("x");
IExpression variableY = new VariableExpression("y");
IExpression expression = new AdditionExpression(variableX, new SubtractionExpression(variableY, new VariableExpression("z")));

// Interpret and evaluate expression
int result = expression.Interpret(context);

Console.WriteLine("Expression result: " + result);
