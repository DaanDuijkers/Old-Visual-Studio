using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Winery
    {
        private string name;
        Barrel barrel;
        Carrier carrier;
        List<Barrel> barrelList = new List<Barrel> ();
        List<Carrier> CarrierList = new List<Carrier> ();

        public Winery(string name)
        {
            this.name = name;
        }

        public void AddCarrier (string name, int capacity)
        {
            carrier = new Carrier (name, capacity);
            CarrierList.Add(carrier);
        }

        public string AddBarrel (int capacity)
        {
            barrel = new Barrel (capacity);
            barrelList.Add(barrel);

            string info = barrel.GetInfo ();
            return info;
        }

        public string RemoveBarrel (string id)
        {
            for (int i = 0; i < barrelList.Count; i++)
            {
                if (barrelList[i].Occupied == false && barrelList[i].ID == id)
                {
                    string removedID = barrelList[i].ID;
                    barrelList.RemoveAt(i);
                    return removedID + " was successfully removed";
                }
            }

            return "Barrel does not exist or is occupied";
        }

        public List<Barrel> GetAllBarrels ()
        {
            return barrelList;
        }
        
        public bool AddWineToBarrel (string id, int amountToAdd, KindOfWine kind)
        {
            foreach (Barrel b in barrelList)
            {
                if (b.ID == id)
                {
                    b.AddWine(amountToAdd, kind);
                    return true;
                }
            }

            return false;
        }
        
        public bool WineFromBarrelToCarrier (string barrelId, string carrierName, int amount)
        {
            foreach (Barrel b in barrelList)
            {
                if (b.ID == barrelId)
                {
                    if (b.removeWine (amount) == true)
                    {
                        string cName = "";
                        foreach (Carrier c in CarrierList)
                        {
                            if (c.GetInfo() == carrierName)
                            {

                            }
                        }
                    }
                }
            }

            return false;
        }
        /*
        public bool WineFromCarrierToBarrel (string carrierName, string barrelId, int amount)
        {

            return
        }*/
    }
}
