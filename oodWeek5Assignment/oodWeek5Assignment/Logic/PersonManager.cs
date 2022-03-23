using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oodWeek5Assignment
{
    public class PersonManager
    {
        private List<Person> persons;
        private ProductManager productManager;

        public PersonManager (ProductManager productManager)
        {
            this.persons = new List<Person>();
            this.productManager = productManager;
        }

        public List<Person> GetAll()
        {
            return this.persons;
        }

        public Person Get(int id)
        {
            foreach (Person p in persons)
            {
                if (p.ID == id)
                {
                    return p;
                }
            }

            return null;
        }

        public bool Add (Person person)
        {
            this.persons.Add(person);
            return true;
        }

        public bool Edit (int id, Person newPerson)
        {
            int i = 0;
            foreach (Person p in persons)
            {
                if (p.ID == id)
                {
                    persons[i] = newPerson;
                }
                i++;
            }

            return false;
        }

        public bool Block (int id)
        {
            foreach(Person p in persons)
            {
                if (p.ID == id)
                {
                    if (p.Active == true)
                    {
                        p.Active = false;
                        return false;
                    }
                    else if (p.Active == false)
                    {
                        p.Active = true;
                        return true;
                    }
                }
            }

            return false;
        }
    }
}