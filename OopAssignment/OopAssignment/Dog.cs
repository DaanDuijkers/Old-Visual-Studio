using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAssignment
{
    public class Dog : Animal
    {
        public Dog(string name, int age, string gender, string notes) : base(name, age, gender, notes)
        {
            this.Species = "Dog";
            this.Price = 29.95;
        }
    }
}
