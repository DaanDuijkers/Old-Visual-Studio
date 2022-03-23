using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    public abstract class Person
    {
        private int age;
        private string name;
        private int pcn;
        private int yearsAtSchool;

        public abstract string ToString();
    }
}
