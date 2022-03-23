using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAboutDogRaces
{
    class Dog
    {
        private String name;
        private String description;

        public Dog(String name, String descr)
        {
            this.name = name;
            this.description = descr;
        }

        public String GetName()
        {
            return this.name;
        }
        public String GetInfo()
        {
            return this.name + ", " + this.description;
        }
    }
}
