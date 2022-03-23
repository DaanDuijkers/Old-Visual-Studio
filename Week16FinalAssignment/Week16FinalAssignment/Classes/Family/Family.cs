using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week16FinalAssignment
{
    public class Family
    {
        private List<Parent> parents;
        private List<Child> children;

        private int id;
        private string familyName;
        private string status;
        private static int count = 1;

        public int ID { get { return this.id; } }
        public string FamilyName { get { return this.familyName; } set { this.familyName = value; } }
        public string Status { get { return this.status; } set { this.status = value; } }
        public List<Parent> Parents { get { return this.parents; } set { this.parents = value; } }
        public List<Child> Children { get { return this.children; } set { this.children = value; } }

        public Family (string familyName)
        {
            this.id = count;
            count++;
            this.familyName = familyName;
            this.status = string.Empty;
            this.parents = new List<Parent>();
            this.children = new List<Child>();
        }
    }
}