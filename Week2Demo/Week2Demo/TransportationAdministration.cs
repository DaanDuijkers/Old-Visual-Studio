using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Demo
{
    public class TransportationAdministration
    {
        private List<Transportation> transportations;

        public TransportationAdministration ()
        {
            this.transportations = new List<Transportation>();
        }

        public void AddTransportation (Transportation t)
        {
            transportations.Add(t);
        }

        public Transportation GetTransportation (int id)
        {
            foreach(Transportation t in transportations)
            {
                if (t.Id == id)
                {
                    return t;
                }
            }
            return null;
        }

        public Transportation[] GetAll()
        {
            return transportations.ToArray();
        }
    }
}
