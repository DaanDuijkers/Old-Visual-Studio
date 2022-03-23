using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Assignment
{
    [Serializable]
    class PassengerRide : Ride
    {
        private int passengers;
        
        public int Passengers { get { return passengers; } }

        public PassengerRide(Vehicle vehicle, DateTime startTime, DateTime endTime, int passengers) : base (vehicle, startTime, endTime)
        {
            this.rideType = RideType.Passenger;
            this.vehicle = vehicle;
            this.startTime = startTime;
            this.endTime = endTime;
            this.passengers = passengers;
            this.completed = false;
        }
    }
}
