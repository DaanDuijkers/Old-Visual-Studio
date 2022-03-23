using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace privateMessenger
{
    class Chat
    {
        private int chatid;
        private string gebruikerid;
        private int beheerid;

        private bool actief;
        private string datum;
        private string date;

        public int Chatid { get { return this.chatid; } set { this.chatid = value; } }
        public string Gebruikerid { get { return this.gebruikerid; } set { this.gebruikerid = value; } }
        public Gebruiker gebruiker { get; set; }

        public int Beheerid { get { return this.beheerid; } set { this.beheerid = value; } }
        public Beheerder beheer { get; set; }
        
        public string Datum { get { return this.datum; } set { this.datum = value; } }

        public bool Actief
        {
            get
            {
                return this.actief;
            }
            set
            {
                this.actief = value;
            }
        }

        public Chat() { }

        //public Chat(int beheedersrid, string gebruikersid, DateTime date) 
        //{
        //    this.Beheerid = beheedersrid;
        //    this.Gebruikerid = gebruikersid;
        //    this.Datum = date;
        //}

        public Chat(int beheerid, string gebruikerid, string date)
        {
            this.beheerid = beheerid;
            this.gebruikerid = gebruikerid;
            this.date = date;
        }

        public override string ToString()
        {
            return $"{this.Chatid}   Beheer:{this.Beheerid} Gebruiker: {this.Gebruikerid}  Tijd:{this.Datum}";
        }

    }
}
