using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oodWeek2Exercise1
{
    public class Street
    {
        private string name;
        private string city;

        public string Name { get { return this.name; } set { this.name = value; } }
        public string City { get { return this.city; } set { this.city = value; } }

        public Street (string name, string city)
        {
            this.Name = name;
            this.City = city;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}