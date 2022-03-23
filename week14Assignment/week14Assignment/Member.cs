using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week14Assignment
{
    class Member
    {
        private int studentNumber;
        private string name;

        public Member (string name)
        {
            this.name = name;
        }

        public Member (string name, int studentNumber)
        {
            this.name = name;
            this.studentNumber = studentNumber;
        }

        public string GetInfo()
        {
            if (studentNumber.Equals(null) || studentNumber == 0)
            {
                return name;
            }
            else
            {
                return name + " (nr. " + studentNumber + ")";
            }
        }
    }
}
