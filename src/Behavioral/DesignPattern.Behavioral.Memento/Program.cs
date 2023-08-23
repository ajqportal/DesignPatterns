// See https://aka.ms/new-console-template for more information
using DesignPattern.Behavioral.Memento.Concretes;
using DesignPattern.Behavioral.Memento.Enums;
using DesignPattern.Behavioral.Memento.Models;

Document document = new Document();
History history = new History();

document.State = DocumentState.Version10;
document.Print();

history.Save(document.CreateMemento());

document.State = DocumentState.Version11;
document.Print();

history.Save(document.CreateMemento());

document.State = DocumentState.Version20;
document.Print();

Memento memento = history.Undo();
if (memento != null)
{
    document.RestoreMemento(memento);
    document.Print();
}