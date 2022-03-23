using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4ReadWriteTextFile
{
    public class GradeException : Exception
    {
        public GradeException (string grade) : base ("Grade " + grade + " not in correct format; must be O, G, S, U, or P")
        {

        }
    }
}
