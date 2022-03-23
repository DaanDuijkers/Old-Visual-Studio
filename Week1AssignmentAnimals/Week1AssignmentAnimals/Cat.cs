using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1AssignmentAnimals
{
    public class Cat : Animal
    {
        public Cat(string name) : base (name)
        {
            this.name = name;
            this.age = 1;
        }

        public Cat (string name, int age) : base (name)
        {
            this.name = name;
            this.age = age;
        }

        public override void CelebrateBirthday()
        {
            if (age < 20)
            {
                age += 1;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}