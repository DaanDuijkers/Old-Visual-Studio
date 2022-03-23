using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1Inheritance
{
    class Transportation
    {
        private int speedInKMH;

        protected int SpeedInKMH { get { return this.speedInKMH; } set { if (value >= 0) { this.speedInKMH = value; } else { this.speedInKMH = 0; } } }

        public Transportation (int speedInKMH)
        {
            this.speedInKMH = speedInKMH;
        }

        public double CalculateHoursTillDestinationInKM (int km)
        {
            return km / this.speedInKMH;
        }

        public virtual string GetInfo()
        {
            return "Speed: " + this.speedInKMH;
        }
    }
}