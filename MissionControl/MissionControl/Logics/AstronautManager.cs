using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionControl
{
    public class AstronautManager
    {
        private List<Astronaut> astronauts;

        public AstronautManager ()
        {
            this.astronauts = new List<Astronaut>();
        }

        public bool AddAstronaut (Astronaut astronaut)
        {
            if (GetAstronaut(astronaut.Name) == null)
            {
                astronauts.Add(astronaut);
                return true;
            }

            throw new NoneUniqueNameException("Astronaut already exists", "astronaut");
        }

        public Astronaut[] GetAstronauts()
        {
            return this.astronauts.ToArray();
        }

        public Astronaut GetAstronaut (string name)
        {
            foreach (Astronaut a in astronauts)
            {
                if (a.Name == name)
                {
                    return a;
                }
            }

            return null;
        }
    }
}