using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oodStudentSystem
{
    public class Administration
    {
        private List<Person> persons;

        public Administration ()
        {
            this.persons = new List<Person>();
        }

        public void AddPerson (Person person)
        {
            this.persons.Add(person);
        }

        public Person GetPerson (int pcn)
        {
            foreach (Person p in persons)
            {
                if (p.PNC == pcn)
                {
                    return p;
                }
            }

            return null;
        }

        public List<Person> GetPersons ()
        {
            return this.persons;
        }
    }
}