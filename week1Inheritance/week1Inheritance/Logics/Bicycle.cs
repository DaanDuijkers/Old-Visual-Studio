using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1Inheritance
{
    class Bicycle : Transportation
    {
        private bool hasLuggageCarrier;

        public Bicycle (bool hasLuggageCarrier, int speedInKMH) : base (speedInKMH)
        {
            this.hasLuggageCarrier = hasLuggageCarrier;
        }

        public override string GetInfo()
        {
            string info = "Bicycle (Has luggage carrier: ";
            if (hasLuggageCarrier == true)
            {
                info += "Yes";
            }
            else
            {
                info += "No";
            }

            return info + ", Speed per KM: " + base.GetInfo() + ")";
        }
    }
}