using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week16FinalAssignment
{
    public abstract class Person
    {
        protected int id;
        protected string firstName;
        protected string lastName;
        protected DateTime birthDate;
        private static int count = 1;

        public int ID { get { return this.id; } }
        public string FirstName { get { return this.firstName; } set { this.firstName = value; } }
        public string LastName { get { return this.lastName; } set { this.lastName = value; } }
        public DateTime BirthDate { get { return this.birthDate; } set { this.birthDate = value; } }

        public Person (string firstName, string lastName, DateTime birthDate)
        {
            this.id = count;
            count++;
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
        }
    }
}