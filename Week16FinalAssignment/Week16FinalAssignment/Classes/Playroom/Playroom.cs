using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week16FinalAssignment
{
    public class Playroom
    {
        private List<Reservation> reservations;
        private List<PlayroomProduct> products;

        private int id;
        private int availableSpace;
        private ShoppingCenter shoppingCenter;
        private static int count = 1;

        public int ID { get { return this.id; } }
        public int AvailableSpace { get { return this.availableSpace; } set { this.availableSpace = value; } }
        public ShoppingCenter ShoppingCenter { get { return this.shoppingCenter; } set { this.shoppingCenter = value; } }
        public List<Reservation> Reservations { get { return this.reservations; } set { this.reservations = value; } }
        public List<PlayroomProduct> Products { get { return this.products; } set { this.products = value; } }

        public Playroom (int availableSpace, ShoppingCenter shoppingCenter)
        {
            this.reservations = new List<Reservation>();
            this.products = new List<PlayroomProduct>();

            this.id = count;
            count++;
            this.availableSpace = availableSpace;
            this.shoppingCenter = shoppingCenter;
        }
    }
}