using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oodWeek5Assignment
{
    public class Screen : Product, Hz, AccessoryDetails
    {
        private string resolution;

        public string Resolution { get { return this.resolution; } set { this.resolution = value; } }
        public int Hz { get; set; }
        public bool Wireless { get; set; }
        public int Reach { get; set; }

        public Screen (string name, string description, float price, int instock, ProductType productType, int height, int width, int depth, string resolution, int hz, bool wireless, int reach) : base (name, description, price, instock, productType, height, width, depth)
        {
            this.Resolution = resolution;
            this.Hz = hz;
            this.Wireless = wireless;
            this.Reach = reach;
        }
    }
}