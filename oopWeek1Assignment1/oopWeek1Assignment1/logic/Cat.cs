using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopWeek1Assignment1
{
    public class Cat : Animal
    {
        public Cat (string name) : base (name)
        {

        }

        public Cat (string name, int age) : base (name, age)
        {

        }

        public override void CelebrateBirthday()
        {
            if (this.age < 25)
            {
                this.age++;
            }
        }

        public override string ToString()
        {
            return "Cat: " + base.ToString();
        }
    }
}