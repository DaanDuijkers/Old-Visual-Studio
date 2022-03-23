using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopWeek1Assignment1
{
    public class Dog : Animal
    {
        public Dog (string name) : base (name)
        {
            
        }

        public Dog (string name, int age) : base (name, age)
        {

        }

        public override void CelebrateBirthday()
        {
            if (this.age < 20)
            {
                this.age++;
            }
        }

        public override string ToString()
        {
            return "Dog: " + base.ToString();
        }
    }
}