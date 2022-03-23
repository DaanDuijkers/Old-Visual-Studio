using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace OopAssignment
{
    public class Bird : Animal
    {
        private string size;

        public string Size { get { return size; } set { size = value; } }

        public Bird(string name, int age, string gender, string notes, string size) : base (name, age, gender, notes)
        {
            this.Species = "Bird";
            this.Size = size;
            if (size == "Small")
            {
                this.Price = 5.50;
            }
            else if (size == "Medium")
            {
                this.Price = 11.00;
            }
            else if (size == "Large")
            {
                this.Price = 16.50;
            }
        }
    }
}
