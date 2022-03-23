using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplane
{
    public class Person
    {
        protected static int id;
        protected string name;
        protected int age;
        private int number = 1;

        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        Person(string name, int age)
        {
            id = number;
            this.name = name;
            this.age = age;
            number++;
        }
    }
}
