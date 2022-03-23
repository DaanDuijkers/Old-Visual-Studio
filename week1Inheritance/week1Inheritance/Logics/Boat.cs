using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1Inheritance
{
    class Boat : Transportation
    {
        private string company;
        private int weight;

        public Boat (string company, int weight, int speedInKMH) : base (speedInKMH)
        {
            this.company = company;
            this.weight = weight;
        }
    }
}