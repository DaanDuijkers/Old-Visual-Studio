using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeDemo
{
    public class NodeEmployee
    {
        public NodeEmployee Parent { get; private set; }
        public List<NodeEmployee> Children { get; private set; }
        public Employee Employee { get; private set; }

        public NodeEmployee (NodeEmployee parent, Employee employee)
        {
            this.Parent = parent;
            this.Employee = employee;
            this.Children = new List<NodeEmployee>();
        }
    }
}
