using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Barrel
    {
        private string id;
        private static int nextFreeNr = 205;
        private int capacity;
        private int amount;
        private KindOfWine kind = KindOfWine.NO_WINE;

        public string ID { get { return id; } private set { id = value; } }
        public int Amount { get { return amount; } private set { amount = value; } }
        public bool Occupied { get; set; }

        public Barrel(int capacity)
        {
            ID = nextFreeNr.ToString();

            if (capacity >= 1 && capacity <= 99)
            {
                ID += "A";
            }
            else if (capacity >= 100 && capacity <= 199)
            {
                ID += "B";
            }
            else if (capacity >= 200 && capacity <= 499)
            {
                ID += "C";
            }
            else if (capacity >= 500)
            {
                ID += "D";
            }

            nextFreeNr++;
            this.capacity = capacity;
            amount = 0;
            Occupied = false;
        }

        public string GetInfo ()
        {
            string info = ID + ", capacity " + capacity;

            return info;
        }

        public bool AddWine (int amountToAdd, KindOfWine kind)
        {
            int inBarrel = capacity - amountToAdd;
            inBarrel -= amount;

            if (inBarrel >= 0)
            {
                if (this.kind == KindOfWine.NO_WINE || kind == this.kind)
                {
                    this.kind = kind;
                }
                else if (this.kind != kind)
                {
                    this.kind = KindOfWine.MIXED;
                }

                amount = amountToAdd;
                Occupied = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool removeWine (int amount)
        {
            int deduction = this.amount - amount;
            if (deduction < 0)
            {
                return false;
            }
            else
            {
                this.amount = deduction;
            }

            if (this.amount == 0)
            {
                Occupied = false;
                kind = KindOfWine.NO_WINE;
            }

            return true;
        }
    }
}
