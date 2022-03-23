using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oodWeek5Assignment
{
    public class Person
    {
        private int id;
        private string username;
        private string password;
        private string email;
        private string postal;
        private bool active;
        private bool isAdmin;
        private ShoppingCart shoppingCart;
        private static int counter = 1;

        public int ID { get { return this.id; } }
        public string Username { get { return this.username; } set { this.username = value; } }
        public string Password { get { return this.password; } set { this.password = value; } }
        public string Email { get { return this.email; } set { this.email = value; } }
        public string Postal { get { return this.postal; } set { this.postal = value; } }
        public bool Active { get { return this.active; } set { this.active = value; } }
        public bool IsAdmin { get { return this.isAdmin; } set { this.isAdmin = value; } }
        public ShoppingCart ShoppingCart { get { return this.shoppingCart; } set { this.shoppingCart = value; } }

        public Person (string username, string password, string email, string postal, ProductManager productManager)
        {
            this.id = counter;
            this.Username = username;
            this.Email = email;
            this.Password = password;
            this.Postal = postal;
            this.Active = true;
            this.IsAdmin = false;
            this.ShoppingCart = new ShoppingCart(productManager);
            counter++;
        }
    }
}