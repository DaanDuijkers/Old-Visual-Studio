using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week16FinalAssignment
{
    public class ProductAvailability
    {
        private Product product;

        public Product ProductInfo { get { return this.product; } set { this.product = value; } }

        public ProductAvailability (Product product)
        {
            this.product = product;
        }
    }
}