using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp66
{
    public class Car : Transportation
    {
        private string licensePlate;
        private Color color;

        public Car(string licensePlate, Color color, int speed): base(speed)
        {
            this.licensePlate = licensePlate;
            this.color = color;
        }

        public override string GetInfo()
        {
            string result = "Car license plate:" + this.licensePlate;
            result += " color:" + this.color.ToString();
            result += base.ToString();
            return result;
        }

    }
}
