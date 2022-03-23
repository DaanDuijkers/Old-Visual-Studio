using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week16FinalAssignment
{
    public class Drink : Product
    {
        private double liter;

        public double Liter { get { return liter; } set { liter = value; } }

        public Drink(string name, double price, string type, double liter) : base(name, price, type)
        {
            this.liter = liter;
        }
    }
}