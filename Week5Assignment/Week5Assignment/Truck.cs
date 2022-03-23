using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Assignment
{
    [Serializable]
    public class Truck : Vehicle
    {
        private int maxWeight;
        private int maxVolume;

        public int MaxWeight { get { return maxWeight; } private set { maxWeight = value; } }
        public int MaxVolume { get { return maxVolume; } private set { maxVolume = value; } }

        public Truck(string licensePlate, int gasUsagePerKM, double pricePerKM, VehicleType vehicleType, int maxWeight, int maxVolume) : base(licensePlate, gasUsagePerKM, pricePerKM, vehicleType)
        {
            this.licensePlate = licensePlate;
            this.gasUsagePerKM = gasUsagePerKM;
            this.pricePerKM = pricePerKM;
            this.vehicleType = vehicleType;
            this.MaxWeight = maxWeight;
            this.MaxVolume = maxVolume;
        }

        public void Edit(string licensePlate, int gasUsagePerKM, double pricePerKM, VehicleType vehicleType, int maxWeight, int maxVolume)
        {
            this.licensePlate = licensePlate;
            this.gasUsagePerKM = gasUsagePerKM;
            this.pricePerKM = pricePerKM;
            this.vehicleType = vehicleType;
            this.maxWeight = maxWeight;
            this.maxVolume = maxVolume;
        }
    }
}
