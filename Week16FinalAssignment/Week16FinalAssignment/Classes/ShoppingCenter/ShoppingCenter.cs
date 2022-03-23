using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week16FinalAssignment
{
    public class ShoppingCenter
    {
        private int id;
        private string name;
        private string address;
        private static int count = 1;

        public int ID { get { return this.id; } }
        public string Name { get { return this.name; } set { this.name = value; } }
        public string Address { get { return this.address; } set { this.address = value; } }

        public ShoppingCenter (string name, string address)
        {
            this.id = count;
            count++;
            this.name = name;
            this.address = address;
        }
    }
}