// See https://aka.ms/new-console-template for more information
using DesignPattern.Structural.Bridge.Abstractions;
using DesignPattern.Structural.Bridge.Concretes;
using DesignPattern.Structural.Bridge.Implementors;
using DesignPattern.Structural.Bridge.Interfaces;

IRenderer vectorRenderer = new VectorRenderer();
IRenderer rasterRenderer = new RasterRenderer();

Shape circle = new Circle(5, vectorRenderer);
Shape square = new Square(4, rasterRenderer);

circle.Draw();
square.Draw();

Console.WriteLine("\nResizing circle by 2x:");
circle.Resize(2);
circle.Draw();

Console.WriteLine("\nResizing square by 3x:");
square.Resize(3);
square.Draw();