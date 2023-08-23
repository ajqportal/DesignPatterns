using DesignPattern.Behavioral.Visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Visitor.Clients
{
    internal class PeopleClient
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
