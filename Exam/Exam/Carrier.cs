using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Carrier
    {
        private string name;
        private int capacity;
        private int amount;

        public int Amount { get { return amount; } set { amount = value; } }

        public Carrier (string name, int capacity)
        {
            this.name = name;
            this.capacity = capacity;
            Amount = 0;
        }
        
        public string GetInfo ()
        {
            return name;
        }
    }
}
