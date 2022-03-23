using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week16FinalAssignment
{
    public class SpecialGadget : Product
    {
        private double compensation;

        public double Compensation { get { return this.compensation; } set { this.compensation = value; } }

        public SpecialGadget (string name, double price, string type, double compensation) : base (name, price, type)
        {
            this.compensation = compensation;
        }
    }
}