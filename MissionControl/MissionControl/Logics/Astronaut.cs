using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionControl
{
    public class Astronaut
    {
        private string nationality;
        public string Name { get; private set; }

        public Astronaut (string name, string nationality)
        {
            this.nationality = nationality;
            this.Name = name;
        }

        public override string ToString()
        {
            return $"Astronaut: {this.Name} is from {this.nationality}";
        }
    }
}