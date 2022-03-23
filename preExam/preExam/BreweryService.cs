using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preExam
{
    class BreweryService
    {
        Tank tank;
        Brewer brewer;
        List<Tank> tanks = new List<Tank> ();
        List <Brewer> brewers = new List<Brewer> ();

        public BreweryService (string name)
        {
            AddBrewer(name);
        }

        public string AddBrewer (string name)
        {
            brewer = new Brewer (name);
            brewers.Add(brewer);
            return brewer.getInfo();
        }

        public bool AddTank (string id, int capacity)
        {
            bool exists = false;
            foreach (Tank t in tanks)
            {
                if (id == t.ID)
                {
                    exists = true;
                }
            }

            if (exists == false)
            {
                tank = new Tank(id, capacity);
                tanks.Add(tank);
                return true;
            }
            else
            {
                return false;
            }
        }

        
        public string RequestTank (string brewerID, int amountOfBeer)
        {
            foreach (Tank t in tanks)
            {
                if (t.ID == brewerID)
                {
                    if (t.Occupied == false)
                    {
                        int freeSpace = t.Capacity - amountOfBeer;

                        if (freeSpace >= 0)
                        {
                            t.InTank = amountOfBeer;

                            string requestAccepted = "You have claimed: Tank " + t.ID + "!";
                            return requestAccepted;
                        }
                        else
                        {
                            return "Does not have enough space!";
                        }
                        
                    }
                    else
                    {
                        return "Occupied!";
                    }
                }
            }
            return "Error!";
        }



        public bool MakeTankEmpty (Tank t)
        {
            if (t.Occupied == true)
            {
                t.Occupied = false;
                t.InTank = 0;
                return true;
            }
            else
            {
                return false;
            }
        }
        /*
        public bool MoveBeer (Tank sourceTank, Tank destinationTank)
        {
            
            return
        }*/

        public List<Tank> GetAllTanks ()
        {
            return tanks;
        }

        public List<Brewer> GetAllBrewers ()
        {
            return brewers;
        }
    }
}
