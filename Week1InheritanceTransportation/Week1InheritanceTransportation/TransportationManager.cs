using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1InheritanceTransportation
{
    public class TransportationManager
    {
        private List<Car> cars;
        private List<Boat> boats;

        public TransportationManager ()
        {
            cars = new List<Car>();
            boats = new List<Boat>();
        }

        public void AddCar (Car car)
        {
            cars.Add(car);
        }

        public void AddBoat (Boat boat)
        {
            boats.Add(boat);
        }
    }
}
