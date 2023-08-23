// See https://aka.ms/new-console-template for more information
using DesignPattern.Creational.Singleton.Loggers;

Logger logger1 = Logger.Instance;
Logger logger2 = Logger.Instance;

Console.WriteLine("Are logger1 and logger2 the same instance? " + (logger1 == logger2));

logger1.Log("Message from logger1.");
logger2.Log("Message from logger2.");
