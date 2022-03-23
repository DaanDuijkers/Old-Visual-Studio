using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week16FinalAssignment
{
    public class ShoppingCenterManager
    {
        private List<ShoppingCenter> shoppingCenters;

        public ShoppingCenterManager()
        {
            this.shoppingCenters = new List<ShoppingCenter>();
        }

        public void Add (ShoppingCenter shoppingCenter)
        {
            this.shoppingCenters.Add(shoppingCenter);
        }
    }
}