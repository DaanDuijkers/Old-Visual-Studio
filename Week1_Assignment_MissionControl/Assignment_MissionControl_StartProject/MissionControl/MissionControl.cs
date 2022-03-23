using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MissionControl
{
    public class MissionControl
    {
        private List<Astronaut> astronauts;
        private List<Mission> missions;

        public MissionControl()
        {
            this.astronauts = new List<Astronaut>();
            this.missions = new List<Mission>();
        }

        public bool AssignToMission(Astronaut a, Mission m)
        {
            bool success = false;
            success = a.AddMission(m);
            if (success)
                success = m.AddAstronaut(a);
            return success;
        }

        public void AddMission(string name, DateTime launchDate, DateTime returnDate, string spaceship)
        {
            missions.Add(new Mission(name, launchDate, returnDate, spaceship));
        }

        public void AddAstronaut(string name, string gender, string nationality)
        {
            astronauts.Add(new Astronaut(name, gender, nationality));
        }

        public Astronaut GetAstronautByName(string name)
        {
            foreach(Astronaut a in astronauts)
            {
                if (a.GetName() == name)
                {
                    return a;
                }
            }
            return null;
        }

        public Mission GetMissionByName(string name)
        {
            foreach(Mission m in missions)
            {
                if (m.GetName() == name)
                {
                    return m;
                }
            }
            return null;
        }

        public int GetDaysInSpace(Astronaut a)
        {
            return a.GetDaysInSpace();
        }

        public string GetLongestMission(Astronaut a)
        {
            return a.GetLongestMission();
        }

        public List<string> GetCompanions(Astronaut a)
        {
            return a.GetCompanions();
        }

        public List<String> GetAllMissions(Astronaut a)
        {
            // returns information about all missions of astronaut a
            List<String> astronautMissionsDetails = new List<String>();
            List<Mission> astronautMissions = a.GetAllMissions();
            foreach(Mission m in astronautMissions)
            {
                astronautMissionsDetails.Add(m.ToString());
            }
            return astronautMissionsDetails;
        }

        public List<string> GetAllMissions()
        {
            // returns information about all missions
            List<String> missionsDetails = new List<String>();
            foreach (Mission m in missions)
            {
                missionsDetails.Add(m.ToString());
            }
            return missionsDetails;
        }
    }
}
