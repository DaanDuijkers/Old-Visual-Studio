using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12Assignment
{
    public class OnlineWorkshop : Workshop
    {
        private string url;

        public string URL { get { return url; } set { url = value; } }

        public OnlineWorkshop (string name, string description, string type, int seats, DateTime date, Person teacher, string url) : base (name, description, type, seats, date, teacher)
        {
            this.url = url;
        }
    }
}