using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oodStudentSystem
{
    public class Student : Person
    {
        private int nrOfECs;

        public Student(int nrOfECs, int age, int pcn, int yearsAtSchool, string name) : base(age, pcn, yearsAtSchool, name)
        {
            this.nrOfECs = nrOfECs;
        }

        public string ToString()
        {

        }

        public void AddECs(int n)
        {
            this.nrOfECs = this.nrOfECs + n;
        }
    }
}