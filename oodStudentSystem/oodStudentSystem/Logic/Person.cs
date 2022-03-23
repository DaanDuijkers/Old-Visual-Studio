using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oodStudentSystem
{
    public abstract class Person
    {
        private int age, pcn, yearsAtSchool;
        private string name;

        public Person (int age, int pcn, int yearsAtSchool, string name)
        {
            this.age = age;
            this.pcn = pcn;
            this.yearsAtSchool = yearsAtSchool;
            this.name = name;
        }

        public void CelebrateBirthday ()
        {
            this.age++;
        }

        public void StartAnotherSchoolYear()
        {
            this.yearsAtSchool++;
        }

        public string ToString()
        {
            return 
        }
    }
}