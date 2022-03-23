using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week16FinalAssignment
{
    public class DrinkAvailability : ProductAvailability
    {
        private double liter;

        public double Liter { get { return this.liter; } set { this.liter = value; } }

        public DrinkAvailability (Product product) : base (product)
        {
            liter = ((Drink)product).Liter;
        }
    }
}