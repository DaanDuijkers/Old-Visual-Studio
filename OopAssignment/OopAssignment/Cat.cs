using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAssignment
{
    public class Cat : Animal
    {
        public Cat(string name, int age, string gender, string notes) : base(name, age, gender, notes)
        {
            this.Species = "Cat";
            if (Age < 10)
            {
                this.Price = 15.00;
            }
            else
            {
                this.Price = 10.00;
            }
        }
    }
}
