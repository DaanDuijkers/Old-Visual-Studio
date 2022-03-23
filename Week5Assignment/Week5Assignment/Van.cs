using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Assignment
{
    [Serializable]
    public class Van : Vehicle
    {
        private int maxPassengers;
        private int maxWeight;
        private int maxVolume;

        public int MaxPassengers { get { return maxPassengers; } private set { maxPassengers = value; } }
        public int MaxWeight { get { return maxWeight; } private set { maxWeight = value; } }
        public int MaxVolume { get { return maxVolume; } private set { maxVolume = value; } }

        public Van (string licensePlate, int gasUsagePerKM, double pricePerKM, VehicleType vehicleType, int maxPassengers, int maximumWeight, int maximumVolume) : base(licensePlate, gasUsagePerKM, pricePerKM, vehicleType)
        {
            this.licensePlate = licensePlate;
            this.gasUsagePerKM = gasUsagePerKM;
            this.pricePerKM = pricePerKM;
            this.vehicleType = vehicleType;
            this.maxPassengers = maxPassengers;
            this.maxWeight = maximumWeight;
            this.maxVolume = maximumVolume;
        }

        public void Edit(string licensePlate, int gasUsagePerKM, double pricePerKM, VehicleType vehicleType, int maxPassengers, int maxWeight, int maxVolume)
        {
            this.licensePlate = licensePlate;
            this.gasUsagePerKM = gasUsagePerKM;
            this.pricePerKM = pricePerKM;
            this.vehicleType = vehicleType;
            this.maxPassengers = maxPassengers;
            this.maxWeight = maxWeight;
            this.maxVolume = maxVolume;
        }
    }
}
