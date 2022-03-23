using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Demo
{
    public class Bicycle : Transportation
    {
        private bool hasLuggageCarrier;

        public Bicycle(bool hasLuggageCarrier, int speed) : base(speed)
        {
            this.hasLuggageCarrier = hasLuggageCarrier;
        }

        public override string ToString()
        {
            return base.ToString() + "; Bicycle: " + this.hasLuggageCarrier.ToString();
        }
    }
}
