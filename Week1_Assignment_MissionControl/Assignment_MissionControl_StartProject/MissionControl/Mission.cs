using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MissionControl
{
    public class Mission
    {
        private string name;
        private DateTime launchDate;
        private DateTime endDate;
        private string spaceShipType;
        private List<Astronaut> astronauts;

        public Mission(string name, DateTime launchDate, DateTime endDate, string spaceShipType)
        {
            this.name = name;
            this.launchDate = launchDate;
            this.endDate = endDate;
            this.spaceShipType = spaceShipType;
            this.astronauts = new List<Astronaut>();
        }

        public int GetDuration()
        {
            return DateTimeToInt(endDate) - DateTimeToInt(launchDate);
        }

        public string GetName()
        {
            return this.name;
        }

        public List<Astronaut> GetAstronauts()
        {
            return this.astronauts;
        }

        private int DateTimeToInt(DateTime theDate)
        {
            return (int)(theDate.Date - new DateTime(1900, 1, 1)).TotalDays + 2;
        }

        public bool AddAstronaut(Astronaut a)
        {
            bool success = false;

            if (!astronauts.Contains(a))
            {
                this.astronauts.Add(a);
                success = true;
            }
            return success;
        }

        public override string ToString()
        {
            string result = "Name: " + this.name + " launch date: " + this.launchDate;
            result += " end date: " + this.endDate + " space ship: " + this.spaceShipType;
            return result;
        }
    }
}
