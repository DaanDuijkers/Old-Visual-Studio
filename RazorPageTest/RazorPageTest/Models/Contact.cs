using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPageTest.Models
{
    public class Contact
    {
        private int id;
        private string name;
        private string email;
        private string country;
        private string subject;
        private static int count = 1;

        public int ID { get { return this.id; } }
        public string Name { get { return this.name; } set { this.name = value; } }
        public string Email { get { return this.email; } set { this.email = value; } }
        public string Country { get { return this.country; } set { this.country = value; } }
        public string Subject { get { return this.subject; } set { this.subject = value; } }

        public Contact()
        {

        }

        public Contact(string name, string email, string country, string subject)
        {
            this.id = count;
            this.Name = name;
            this.Email = email;
            this.Country = country;
            this.Subject = subject;
            count++;
        }
    }
}