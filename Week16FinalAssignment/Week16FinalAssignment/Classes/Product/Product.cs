using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week16FinalAssignment
{
    public class Product
    {
        protected string name;
        protected double price;
        protected string type;

        public string Name { get { return this.name; } set { this.name = value; } }
        public double Price { get { return this.price; } set { this.price = value; } }
        public string Type { get { return this.type; } set { this.type = value; } }

        public Product (string name, double price, string type)
        {
            this.name = name;
            this.price = price;
            this.type = type;
        }
    }
}