using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12Assignment
{
    public abstract class Workshop
    {
        protected int id;
        protected string name, description, type;
        protected bool started;
        protected Person teacher;
        protected DateTime date;
        protected List<Seat> seats;

        protected static int count = 1;

        public int ID { get { return id; } }
        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }
        public string Type { get { return type; } }
        public bool Started { get { return started; } }
        public Person Teacher { get { return teacher; } set { teacher = value; } }
        public DateTime Date { get { return date; } set { date = value; } }
        public List<Seat> Seats { get { return seats; } set { seats = value; } }

        public Workshop (string name, string description, string type, int seats, DateTime date, Person teacher)
        {
            this.id = count;
            this.name = name;
            this.description = description;
            this.type = type;
            this.date = date;
            this.teacher = teacher;
            this.started = false;
            count++;

            this.seats = new List<Seat>();
            for (int i = 1; i <= seats; i++)
            {
                if (type == "INBUILDING")
                {
                    this.seats.Add(new BuildingSeat());
                }
                else if (type == "ONLINE")
                {

                    this.seats.Add(new OnlineSeat());
                }
            }
        }

        public void Start ()
        {
            this.started = true;
        }
    }
}