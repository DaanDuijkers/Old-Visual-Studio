using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oodWeek5Assignment
{
    public class Accessory : Product
    {
        private int reach;
        private bool wireless;

        public int Reach { get { return this.reach; } set { this.reach = value; } }
        public bool Wireless { get { return this.wireless; } set { this.wireless = value; } }

        public Accessory (string name, string description, float price, int instock, ProductType productType, int height, int width, int depth, int reach, bool wireless) : base (name, description, price, instock, productType, height, width, depth)
        {
            this.Reach = reach;
            this.Wireless = wireless;
        }
    }
}