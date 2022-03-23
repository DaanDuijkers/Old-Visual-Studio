using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week16FinalAssignment
{
    class ReservationLimit : Reservation
    {
        private double spendingLimit;

        public double SpendingLimit { get { return this.spendingLimit; } set { this.spendingLimit = value; } }

        public ReservationLimit (string phone, DateTime date, DateTime beginTime, DateTime endTime, double spendingLimit, Family family) : base (phone, date, beginTime,endTime, family)
        {
            this.spendingLimit = spendingLimit;
        }
    }
}