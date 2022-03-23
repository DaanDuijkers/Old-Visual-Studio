using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oodStudentSystem
{
    public class Teacher : Person
    {
        private JobPosition position;
        private double salary;

        public Teacher(JobPosition position, double salary, int age, int pcn, int yearsAtSchool, string name) : base(age, pcn, yearsAtSchool, name)
        {
            this.position = position;
            this.salary = salary;
        }
    }
}