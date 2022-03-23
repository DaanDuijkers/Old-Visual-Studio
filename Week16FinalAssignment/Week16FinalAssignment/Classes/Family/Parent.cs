using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week16FinalAssignment
{
    public class Parent : Person
    {
        private string phone;
        private string email;
        private string address;
        private string town;

        public string Phone { get { return this.phone; } set { this.phone = value; } }
        public string Email { get { return this.email; } set { this.email = value; } }
        public string Address { get { return this.address; } set { this.address = value; } }
        public string Town { get { return this.town; } set { this.town = value; } }

        public Parent(string firstName, string lastName, DateTime birthDate, string phone, string email, string address, string town) : base (firstName, lastName, birthDate)
        {
            this.phone = phone;
            this.email = email;
            this.address = address;
            this.town = town;
        }
    }
}