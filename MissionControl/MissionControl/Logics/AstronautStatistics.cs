using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionControl
{
    public class AstronautStatistics
    {
        public int TotalDaysInSpace { get; private set; }
        public Mission[] missions { get; private set; }
        public Mission LongestMission { get; private set; }
        public Astronaut[] astronauts { get; private set; }

        public AstronautStatistics (MissionManager missionManager, AstronautManager astronautManager, )
        {

        }

        private Mission[] GetMissionsOn (Astronaut astronaut)
        {
            return null;
        }

        private void GetTotalDaysInSpace (Mission[] missions)
        {

        }

        private void GetLongestMission (Mission[] missions)
        {

        }

        private void GetTraveledWith (Astronaut[] astronauts)
        {

        }
    }
}