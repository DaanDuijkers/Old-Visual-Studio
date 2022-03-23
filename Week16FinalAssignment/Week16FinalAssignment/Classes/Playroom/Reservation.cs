using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week16FinalAssignment
{
    public class Reservation
    {
        protected List<Order> orders;

        protected int id;
        protected string phone;
        protected DateTime date;
        protected DateTime beginTime;
        protected DateTime endTime;
        protected double bill;
        protected Family family;
        protected int count = 1;

        public int ID { get { return this.id; } }
        public string Phone { get { return this.phone; } set { this.phone = value; } }
        public DateTime Date { get { return this.date; } set { this.date = value; } }
        public DateTime BeginTime { get { return this.beginTime; } set { this.beginTime = value; } }
        public DateTime EndTime { get { return this.endTime; } set { this.endTime = value; } }
        public double Bill { get { return this.bill; } set { this.bill = value; } }
        public List<Order> Orders { get { return this.orders; } set { this.orders = value; } }
        public Family Family { get { return this.family; } set { this.family = value; } }

        public Reservation (string phone, DateTime date, DateTime beginTime, DateTime endTime, Family family)
        {
            this.id = count;
            count++;
            this.phone = phone;
            this.date = date;
            this.beginTime = beginTime;
            this.endTime = endTime;
            this.family = family;
        }
    }
}