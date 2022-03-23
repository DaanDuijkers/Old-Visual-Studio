using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAssignment
{
    public class Animal
    {
        protected int id;
        protected string species;
        protected string name;
        protected int age;
        protected string gender;
        protected string notes;
        protected double price;
        protected bool adopted;
        private static int number = 0;

        public int ID { get { return id; } set { id = value; } }
        public string Species { get { return species; } set { species = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string Gender { get { return gender; } set { gender = value; } }
        public string Notes { get { return notes; } set { notes = value; } }
        public double Price { get { return price; } set { price = value; } }
        public bool Adopted { get { return adopted; } set { adopted = value; } }

        public Animal(string name, int age, string gender, string notes)
        {
            number++;
            this.ID = number;
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Notes = notes;
            this.Adopted = false;
        }

        public bool IsAdopted()
        {
            if (adopted == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
