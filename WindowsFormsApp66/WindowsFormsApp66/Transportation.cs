using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp66
{
    public class Transportation
    {
        protected int speedKMH;

        public Transportation(int speedKMH)
        {
            this.speedKMH = speedKMH;
        }

        public double CalculateHoursTillDestination(int km)
        {
            return 0.0;
        }

        public virtual string GetInfo()
        {
            return "Speed: "+ speedKMH.ToString();
        }
    }
}
