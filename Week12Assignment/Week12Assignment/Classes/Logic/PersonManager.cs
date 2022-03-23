using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12Assignment
{
    public class PersonManager
    {
        private List<Person> persons;

        public PersonManager ()
        {
            persons = new List<Person> ();
        }

        public Person Get (string PSN)
        {
            foreach (Person p in persons)
            {
                if (p.PSN == PSN)
                {
                    return p;
                }
            }

            return null;
        }

        public List<Person> GetAll ()
        {
            return persons;
        }

        public bool Add (Person person)
        {
            foreach (Person p in persons)
            {
                if (p.PSN == person.PSN)
                {
                    return false;
                }
            }

            persons.Add(person);
            return true;
        }

        public bool Edit (Person oldPerson, Person newPerson)
        {
            int i = 0;
            foreach (Person p in persons)
            {
                if (p.PSN == oldPerson.PSN)
                {
                    int i2 = 0;
                    foreach (Person np in persons)
                    {
                        if (np.PSN == newPerson.PSN && persons[i] != persons[i2])
                        {
                            return false;
                        }

                        i2++;
                    }

                    p.PSN = newPerson.PSN;
                    p.Type = newPerson.Type;
                    p.FirstName = newPerson.FirstName;
                    p.LastName = newPerson.LastName;
                    p.ClassName = newPerson.ClassName;
                    p.Email = newPerson.Email;
                }

                i++;
            }

            return true;
        }

        public void Remove (Person person)
        {
            persons.Remove(person);
        }
    }
}