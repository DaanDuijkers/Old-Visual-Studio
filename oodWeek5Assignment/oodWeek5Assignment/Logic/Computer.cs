using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oodWeek5Assignment
{
    public class Computer : Product, Hz
    {
        private string cpu;
        private string gpu;
        private int ram;
        private string motherboard;

        public string CPU { get { return this.cpu; } set { this.cpu = value; } }
        public string GPU { get { return this.gpu; } set { this.gpu = value; } }
        public int RAM { get { return this.ram; } set { this.ram = value; } }
        public string Motherboard { get { return this.motherboard; } set { this.motherboard = value; } }
        public int Hz { get; set; }

        public Computer (string name, string description, float price, int instock, ProductType productType, int height, int width, int depth, string cpu, string gpu, int ram, string motherboard, int hz) : base(name, description, price, instock, productType, height, width, depth)
        {
            this.CPU = cpu;
            this.GPU = gpu;
            this.RAM = ram;
            this.Motherboard = motherboard;
            this.Hz = hz;
        }
    }
}