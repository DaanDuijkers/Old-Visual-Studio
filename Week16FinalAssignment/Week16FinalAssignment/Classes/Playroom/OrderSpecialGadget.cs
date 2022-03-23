using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week16FinalAssignment
{
    public class OrderSpecialGadget : Order
    {
        private DateTime beginTime;
        private DateTime endTime;

        public DateTime BeginTime { get { return this.beginTime; } set { this.endTime = value; } }
        public DateTime EndTime { get { return this.endTime; } set { this.endTime = value; } }

        public OrderSpecialGadget(PlayroomProduct product, DateTime beginTime) : base (product)
        {
            this.beginTime = beginTime;
            this.endTime = beginTime.AddHours(1);
        }
    }
}