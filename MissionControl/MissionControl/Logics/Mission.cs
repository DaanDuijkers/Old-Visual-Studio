using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionControl
{
    public class Mission
    {
        private List<Astronaut> astronauts;
        private string spaceship;
        public string Name { get; private set; }
        public DateTime LaunchDate { get; private set; }
        public DateTime ReturnDate { get; private set; }
        
        public Mission (string name, string spaceship, DateTime launchDate, DateTime returnDate)
        {
            this.Name = name;
            this.spaceship = spaceship;
            this.LaunchDate = launchDate;
            this.ReturnDate = returnDate;
            this.astronauts = new List<Astronaut>();
        }

        public bool AssignAstronaut(Astronaut astronaut)
        {
            if (!HasAstronaut(astronaut))
            {
                this.astronauts.Add(astronaut);
                return true;
            }

            throw new AstronautAlreadyAssignedException("The astronaut was already assigned", "astronaut");
        }

        public void UnassignAstronaut (string name)
        {
            for (int i = 0; i < astronauts.Count; i++)
            {
                if (astronauts[i].Name == name)
                {
                    astronauts.RemoveAt(i);
                }
            }
        }

        public Astronaut[] GetAssignedAstronaut ()
        {
            return this.astronauts.ToArray();
        }

        public bool HasAstronaut (Astronaut astronaut)
        {
            return astronauts.Contains(astronaut);
        }

        public override string ToString()
        {
            string message = "";
            if (astronauts.Count == 0)
            {
                message += "No astronauts assigned yet";
            }
            else
            {
                message += "Astronauts:";
                for (int i = 0; i < astronauts.Count - 1; i++)
                {
                    message += $"{astronauts[i].Name}, ";
                }
                message += astronauts[astronauts.Count - 1].Name;
            }
            return $"Mission: {this.Name}, {message}";
        }
    }
}