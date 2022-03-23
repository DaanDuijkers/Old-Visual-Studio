using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preExam
{
    class Tank
    {
        private string id;
        private int capacity;

        public string ID { get { return id; } set { id = value; } }
        public int Capacity { get { return capacity; } set { capacity = value; } }
        public bool Occupied { get; set; }
        public int InTank { get; set; }
        public string BrewerID { get; set; }

        public Tank (string id, int capacity)
        {
            ID = id;
            Capacity = capacity;
            Occupied = false;
            InTank = 0;
            BrewerID = null;
        }

        public string GetInfo ()
        {
            string t = ID + ", " + Capacity;
            return t;
        }
    }
}
