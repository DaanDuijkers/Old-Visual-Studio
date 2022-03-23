using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStreetApp
{
    public class Street
    {
        public string Name { get; set; }
        public string City { get; set; }

        public Street(string Name, string City)
        {
            this.Name = Name;
            this.City = City;
        }

        public override string ToString()
        {
            return this.Name + " " + this.City;
        }
    }
}
