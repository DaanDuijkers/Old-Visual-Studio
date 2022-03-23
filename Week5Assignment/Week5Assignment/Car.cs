using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Assignment
{
    [Serializable]
    public class Car : Vehicle
    {
        private int maxPassengers;

        public int MaxPassengers { get { return maxPassengers; } }

        public Car(string licensePlate, int gasUsagePerKM, double pricePerKM, VehicleType vehicleType, int maxPassengers) : base(licensePlate, gasUsagePerKM, pricePerKM, vehicleType)
        {
            this.licensePlate = licensePlate;
            this.gasUsagePerKM = gasUsagePerKM;
            this.pricePerKM = pricePerKM;
            this.vehicleType = vehicleType;
            this.maxPassengers = maxPassengers;
        }

        public void Edit (string licensePlate, int gasUsagePerKM, double pricePerKM, VehicleType vehicleType, int maxPassengers)
        {
            this.licensePlate = licensePlate;
            this.gasUsagePerKM = gasUsagePerKM;
            this.pricePerKM = pricePerKM;
            this.vehicleType = vehicleType;
            this.maxPassengers = maxPassengers;
        }
    }
}
