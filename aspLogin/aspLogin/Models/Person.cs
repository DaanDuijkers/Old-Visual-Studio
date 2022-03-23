using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspLogin
{
    public class Person
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Postal { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }

        Person()
        { }

        public Person(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public Person(int id, string username, string password, string email, string postal, bool isActive, bool isAdmin)
        {
            this.ID = id;
            this.Username = username;
            this.Password = password;
            this.Email = email;
            this.Postal = postal;
            this.IsActive = isActive;
            this.IsAdmin = isAdmin;
        }
    }
}