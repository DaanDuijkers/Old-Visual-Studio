using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MissionControl
{
    public class Astronaut
    {
        private string name;
        private string gender;
        private string nationality;
        private List<Mission> missions;

        public Astronaut(string name, string gender, string nationality)
        {
            this.name = name;
            this.gender = gender;
            this.nationality = nationality;
            this.missions = new List<Mission>();
        }

        public int GetDaysInSpace()
        {
            int totalDays = 0;
            foreach(Mission m in missions)
            {
                totalDays += m.GetDuration();
            }
            return totalDays;
        }

        public string GetLongestMission()
        {
            Mission longestMission = null;
            int durationLongestMission = 0;

            foreach(Mission m in missions)
            {
                if (m.GetDuration() > durationLongestMission)
                {
                    durationLongestMission = m.GetDuration();
                    longestMission = m;
                }
            }
            if (longestMission == null)
                return "No mission";
            else
                return longestMission.GetName();
        }

        public string GetName()
        {
            return this.name;
        }

        public List<string> GetCompanions()
        {
            List<Astronaut> companions = new List<Astronaut>();
            List<string> companionNames = new List<string>();

            foreach (Mission m in missions)
            {
                List<Astronaut> astronauts = m.GetAstronauts();
                foreach (Astronaut a in astronauts)
                {
                    if (!companions.Contains(a))
                    {
                        if (a.GetName() != this.name) // astronaut is not his/her own companion
                        {
                            companions.Add(a);
                            companionNames.Add(a.GetName());
                        }
                    }
 
                }
            }
            return companionNames;
        }

        public List<Mission> GetAllMissions()
        {
            return this.missions;
        }

        public bool AddMission(Mission m)
        {
            bool success = false;

            if (!missions.Contains(m))
            {
                this.missions.Add(m);
                success = true;
            }
            return success; 
        }
    }
}
