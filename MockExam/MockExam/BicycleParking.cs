using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockExam
{
    class BicycleParking
    {
        private double pricePerHour;
        private double surchangeElectricPerHour;
        List<Bicycle> bicycles;

        public BicycleParking (double pricePerHour, double surchangeElectricPerHour)
        {
            this.pricePerHour = pricePerHour;
            this.surchangeElectricPerHour = surchangeElectricPerHour;
            bicycles = new List<Bicycle> ();
        }

        private Bicycle GetBicycle (string ticketNumber)
        {

            return
        }

        public string ParkBicycle (Type BicycleType)
        {

            return
        }

        public double RetrieveBicycle (string ticketNumber, int hoursInParking, string zipcode)
        {

            return
        }

        public Bicycle[] GetAllRetrievedBicycles (string partialZipcode)
        {

            return
        }
    }
}
