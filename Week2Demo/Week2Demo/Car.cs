using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Week2Demo
{
    public class Car : Transportation
    {
        private string licensePlate;
        private string color;

        public Car(string licensePlate, string color, int speed) : base (speed)
        {
            this.licensePlate = licensePlate;
            this.color = color;
        }

        public override string MakeSound()
        {
            return "Vroom";
        }

        public override string ToString()
        {
            return base.ToString() + "; Car: licensePlate " + this.licensePlate + "; Color: " + this.color;
        }
    }
}
