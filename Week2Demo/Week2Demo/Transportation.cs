using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Demo
{
    public abstract class Transportation
    {
        protected int id;
        protected int speedKMH;
        private static int number = 0;

        public Transportation (int speedKMH)
        {
            number++;
            this.id = number;
            this.speedKMH = speedKMH;
        }

        public int Id { get { return this.id; } }

        public abstract string MakeSound();

        public double CalculateHoursTillDestination (int km)
        {
            // implementation irrelevant

            return 0.0;
        }

        public override string ToString()
        {
            return "Id: " + this.id.ToString() + "; Speed: " + this.speedKMH;
        }
    }
}
