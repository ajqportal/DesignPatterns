// See https://aka.ms/new-console-template for more information
using DesignPattern.Structural.Proxy.Interfaces;
using DesignPattern.Structural.Proxy.Proxies;

IImage image = new ProxyImage("example.jpg");

// Image will be loaded and displayed when needed
image.Display();

Console.WriteLine("Image will not be reloaded");
image.Display();
