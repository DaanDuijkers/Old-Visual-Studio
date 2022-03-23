using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAssignment
{
    public class Customer
    {
        private int id;
        private string name;
        private string zipCode;
        private string city;
        private static int number = 0;

        public int ID { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string ZipCode { get { return zipCode; } set { zipCode = value; } }
        public string City { get { return city; } set { city = value; } }

        public Customer(string name, string zipCode, string city)
        {
            number++;
            this.ID = number;
            this.Name = name;
            this.ZipCode = zipCode;
            this.City = city;

            Save();
        }

        private void Save()
        {
            string info = "ID: " + ID.ToString();
            info += ". | Name: " + Name;
            info += " | Zipcode: " + ZipCode;
            info += " | City: " + City;
        }
    }
}
