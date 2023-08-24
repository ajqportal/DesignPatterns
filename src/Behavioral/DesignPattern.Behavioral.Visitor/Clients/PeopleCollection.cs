using DesignPattern.Behavioral.Visitor.Interfaces;

namespace DesignPattern.Behavioral.Visitor.Clients
{
    internal class PeopleCollection
    {
        private List<IPersonElement> _people = new List<IPersonElement>();

        public void AddPerson(IPersonElement person)
            => _people.Add(person);

        public void Accept(IVisitor visitor)
        {
            foreach(var person in _people)
            {
                person.Accept(visitor);
            }
        }
    }
}
