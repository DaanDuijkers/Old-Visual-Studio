using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1AssignmentAnimals
{
    public class Animal
    {
        protected string name;
        protected int age;

        public Animal (string name)
        {
            this.name = name;
            this.age = 1;
        }

        public Animal (string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual void CelebrateBirthday()
        {
            if (age < 100)
            {
                age += 1;
            }
        }

        public virtual string ToString()
        {
            return name + " (" + age + " year)";
        }
    }
}
