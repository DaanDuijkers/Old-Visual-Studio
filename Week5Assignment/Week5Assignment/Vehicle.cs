using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Assignment
{
    [Serializable]
    public abstract class Vehicle
    {
        protected string licensePlate;
        protected int gasUsagePerKM;
        protected double pricePerKM;
        protected int riddenKM;
        protected int consumedFuel;
        protected VehicleType vehicleType;
        protected bool available;

        public string LicensePlate { get { return licensePlate; } }
        public int GasUsagePerKM { get { return gasUsagePerKM; } }
        public double PricePerKM { get { return pricePerKM; } }
        public int TotalRiddenKM { get { return riddenKM; } }
        public int ConsumedFuel { get { return consumedFuel; } }
        public VehicleType VehicleType { get { return vehicleType; } }
        public bool Available { get { return available; } }


        public Vehicle (string licensePlate, int gasUsagePerKM, double pricePerKM, VehicleType vehicleType)
        {
            this.licensePlate = licensePlate;
            this.gasUsagePerKM = gasUsagePerKM;
            this.pricePerKM = pricePerKM;
            this.riddenKM = 0;
            this.vehicleType = vehicleType;
            this.available = true;
        }

        public void Rent ()
        {
            this.available = false;
        }

        public void Return (int riddenKM)
        {
            this.available = true;
            this.riddenKM += riddenKM;
            this.consumedFuel = this.riddenKM * this.gasUsagePerKM;
        }
    }
}
