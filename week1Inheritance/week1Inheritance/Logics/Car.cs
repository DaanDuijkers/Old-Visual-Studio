﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1Inheritance
{
    class Car : Transportation
    {
        private string licensePlate;
        private Color color;

        public Car (string licensePlate, Color color, int speedInKMH) : base (speedInKMH)
        {
            this.licensePlate = licensePlate;
            this.color = color;
        }
    }
}