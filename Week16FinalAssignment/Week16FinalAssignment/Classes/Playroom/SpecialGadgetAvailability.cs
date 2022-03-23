using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week16FinalAssignment
{
    public class SpecialGadgetAvailability : ProductAvailability
    {
        private bool available;

        public bool Available { get { return this.available; } set { this.available = value; } }

        public SpecialGadgetAvailability (Product product) : base (product)
        {
            this.ProductInfo = (SpecialGadget)product;
            this.available = true;
        }
    }
}