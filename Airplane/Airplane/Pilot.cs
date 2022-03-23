using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplane
{
    public class Pilot : Person
    {
        private bool senior = false;

        Pilot (string name, int age) : base (age, name)
        {
            this.name = name;
            this.age = age;
        }

        public void PromoteToSenior()
        {
            senior = true;
        }
    }
}
