// See https://aka.ms/new-console-template for more information
using DesignPattern.Structural.Flyweight.Factories;
using DesignPattern.Structural.Flyweight.Interfaces;

TextStyleFactory textStyleFactory = new TextStyleFactory();

ITextFormatter bold12 = textStyleFactory.GetStyle("Bold", 12);
ITextFormatter italic14 = textStyleFactory.GetStyle("Italic", 14);
ITextFormatter underline12 = textStyleFactory.GetStyle("Underline", 12);
ITextFormatter bold12Again = textStyleFactory.GetStyle("Bold", 12); // Reusing existing style

bold12.Format("Hello, world!");
italic14.Format("Flyweight pattern example");
underline12.Format("Minimizing memory usage");
bold12Again.Format("Reusing style");

Console.WriteLine($"Is bold12 the same instance as bold12Again? {ReferenceEquals(bold12, bold12Again)}");
