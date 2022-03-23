using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMediaBazaar
{
    public class Department
    {
        private int id;
        private string name;
        private List<Employee> employees;

        public int ID { get { return this.id; } }
        public string Name { get { return this.name; } set { this.name = value; } }
        public List<Employee> Employees { get { return this.employees; } set { this.employees = value; } }

        public Department (int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}