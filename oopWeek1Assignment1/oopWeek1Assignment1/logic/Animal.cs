using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopWeek1Assignment1
{
    public abstract class Animal
    {
        protected int id;
        protected string name;
        protected int age;
        private static int count = 1;

        public Animal (string name)
        {
            this.id = count;
            this.name = name;
            this.age = 1;
            count++;
        }

        public Animal(string name, int age)
        {
            this.id = count;
            this.name = name;
            this.age = age;
            count++;
        }

        public virtual void CelebrateBirthday ()
        {
            if (this.age < 100)
            {
                this.age++;
            }
        }

        public virtual string ToString ()
        {
            return this.name + " (" + this.age + " year)";
        }
    }
}