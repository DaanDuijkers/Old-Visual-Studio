using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12Assignment
{
    public class Person
    {
        private string psn, type, firstName, lastName, className, email;

        public string PSN { get { return psn; } set { psn = value; } }
        public string Type { get { return type; } set { type = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string ClassName { get { return className; } set { className = value; } }
        public string Email { get { return email; } set { email = value; } }

        public Person (string psn, string type, string firstName, string lastName, string className, string email)
        {
            this.psn = psn;
            this.type = type;
            this.firstName = firstName;
            this.lastName = lastName;
            this.className = className;
            this.email = email;
        }
    }
}