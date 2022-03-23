using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12Assignment
{
    public abstract class Seat
    {
        protected Person occupant;

        public Person Occupant { get { return occupant; } }

        public void Reserve (Person person)
        {
            this.occupant = person;
        }

        public void CancelReservation ()
        {
            this.occupant = null;
        }
    }
}