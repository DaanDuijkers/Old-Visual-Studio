using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeDemo
{
    public class Employee
    {
        public string Name { get; set; }
        public Job JobPosition { get; set; }
        public Employee (string name, Job jobPosition)
        {
            this.Name = name;
            this.JobPosition = jobPosition;
        }
    }
}
