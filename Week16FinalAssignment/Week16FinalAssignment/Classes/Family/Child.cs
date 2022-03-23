using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week16FinalAssignment
{
    public class Child : Person
    {
        private string note;

        public string Note { get { return this.note; } set { this.note = value; } }

        public Child(string firstName, string lastName, DateTime birthDate, string note) : base(firstName, lastName, birthDate)
        {
            this.note = note;
        }
    }
}