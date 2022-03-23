using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12Assignment
{
    public class BuildingSeat : Seat
    {
        private int number;
        private int count = 1;

        public int Number { get { return number; } }

        public BuildingSeat ()
        {
            this.number = count;
            count++;
        }
    }
}