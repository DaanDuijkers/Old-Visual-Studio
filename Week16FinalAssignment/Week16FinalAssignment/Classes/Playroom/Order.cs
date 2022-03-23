using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week16FinalAssignment
{
    public class Order
    {
        protected PlayroomProduct product;

        public PlayroomProduct Product { get { return this.product; } set { this.product = value; } }

        public Order (PlayroomProduct product)
        {
            this.product = product;
        }
    }
}