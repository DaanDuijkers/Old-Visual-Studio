using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2AssignmentAnimals
{
    public class Dog : Animal
    {
        public Dog (string name) : base(name)
        {
            this.name = name;
        }

        public override string Speak()
        {
            return "Woof";
        }
    }
}
