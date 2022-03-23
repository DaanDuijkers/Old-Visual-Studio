using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1InheritanceTransportation
{
    public class Car : Transportation
    {
        private string licencePlate;
        private string color;

        public Car (string licencePlate, string color, int speedKMH) : base (speedKMH)
        {
            this.licencePlate = licencePlate;
            this.color = color;
            this.speedKMH = speedKMH;
        }
    }
}
