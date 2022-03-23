using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionControl
{
    public class MissionManager
    {
        private List<Mission> missions;

        public MissionManager()
        {
            this.missions = new List<Mission>();
        }

        public bool AddMission(Mission mission)
        {
            if (GetMission(mission.Name) == null)
            {
                missions.Add(mission);
                return true;
            }

            throw new NoneUniqueNameException("Mission already exists", "mission");
        }

        public Mission[] GetMissions()
        {
            return this.missions.ToArray();
        }

        public Astronaut GetMission(string name)
        {
            foreach (Mission m in missions)
            {
                if (m.Name == name)
                {
                    return m;
                }
            }

            return null;
        }
    }
}