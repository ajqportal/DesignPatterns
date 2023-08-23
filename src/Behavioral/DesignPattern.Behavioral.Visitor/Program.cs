// See https://aka.ms/new-console-template for more information
using DesignPattern.Behavioral.Visitor.Clients;
using DesignPattern.Behavioral.Visitor.Models;
using DesignPattern.Behavioral.Visitor.Visitors;

ConsoleVisitor consoleVisitor = new ConsoleVisitor();
EmailVisitor emailVisitor = new EmailVisitor();

Person person1 = new Person("Alice");
Person person2 = new Person("Bob");

PeopleClient peopleCollection = new PeopleClient();
peopleCollection.AddPerson(person1);
peopleCollection.AddPerson(person2);

Console.WriteLine("Using Console Visitor:");
peopleCollection.Accept(consoleVisitor);

Console.WriteLine("\nUsing Email Visitor:");
peopleCollection.Accept(emailVisitor);
