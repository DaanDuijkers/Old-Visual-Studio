using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12Assignment
{
    public class BuildingWorkshop : Workshop
    {
        private string address, room;

        public string Address { get { return address; } set { address = value; } }
        public string Room { get { return room; } set { room = value; } }

        public BuildingWorkshop (string name, string description, string type, int seats, DateTime date, Person teacher, string address, string room) : base (name, description, type, seats, date, teacher)
        {
            this.address = address;
            this.room = room;
        }
    }
}