using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2AssignmentAnimals
{
    public abstract class Animal
    {
        protected string name;

        protected Animal (string name)
        {
            this.name = name;
        }

        public string Name { get { return name; } }

        public abstract string Speak ();

        public override string ToString()
        {
            return this.Name;
        }
    }
}
