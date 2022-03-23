using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Assignment
{
    [Serializable]
    public abstract class Ride
    {
        protected int id;
        protected RideType rideType;
        protected Vehicle vehicle;
        protected DateTime startTime;
        protected DateTime endTime;
        protected int riddenKM;
        protected double totalPrice;
        protected bool completed;
        protected static int count = 1;

        public int ID { get { return id; } }
        public RideType RideType { get { return rideType; } }
        public Vehicle Vehicle { get { return vehicle; } }
        public DateTime StartTime { get { return startTime; } }
        public DateTime EndTime { get { return endTime; } }
        public int RiddenKM { get { return riddenKM; } }
        public double TotalPrice { get { return totalPrice; } }
        public bool Completed { get { return completed; } }

        public Ride (Vehicle vehicle, DateTime startingTime, DateTime endTime)
        {
            this.id = count;
            this.vehicle = vehicle;
            this.vehicle.Rent();
            this.startTime = startingTime;
            this.endTime = endTime;
            this.completed = false;
            count++;
        }

        public void EndRide (int riddenKM)
        {
            this.completed = true;
            this.riddenKM = riddenKM;
            this.totalPrice = this.riddenKM * vehicle.PricePerKM;
            this.vehicle.Return(riddenKM);
        }
    }
}
