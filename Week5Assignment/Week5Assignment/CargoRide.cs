using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Assignment
{
    [Serializable]
    class CargoRide : Ride
    {
        private int cargoVolume;
        private int cargoWeight;

        public int CargoVolume { get { return cargoVolume; } }
        public int CargoWeight { get { return cargoWeight; } }

        public CargoRide(Vehicle vehicle, DateTime startTime, DateTime endTime, int cargoVolume, int cargoWeight) : base (vehicle, startTime, endTime)
        {
            this.rideType = RideType.Cargo;
            this.vehicle = vehicle;
            this.startTime = startTime;
            this.endTime = endTime;
            this.cargoVolume = cargoVolume;
            this.cargoWeight = cargoWeight;
            this.completed = false;
        }
    }
}
