using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace privateMessenger
{
    class Post : Gebruiker
    {
        private int postid;
        private int beheerderid;

        private string postbeheerder;
        //private string gebruikersid;
       // private string gebruikertekst;
        private DateTime date;

        public int Postid { get { return this.postid; } set { this.postid = value; } }
        public int Beheerderid { get { return this.beheerderid; } set { this.beheerderid = value; } }
        // public Beheerder beheerder { get; set; }
        public string Postbeheerder { get { return this.postbeheerder; } set { this.postbeheerder = value; } }
     // public string Gebruikertekst { get { return this.gebruikertekst; } set { this.gebruikertekst = value; } }
       // public string Gebruikersid { get { return this.gebruikersid; } set { this.gebruikersid = value; } }
        public DateTime Date { get { return this.date; } set { this.date = value; } }

        public Post() 
        { 
        
        }

   
        public Post(string gebruikersid, string gebruikertekst)
        {
            this.Gebruikerid = gebruikersid;
            //this.Gebruikertekst = gebruikertekst;
        }

        public Post(int beheerid, string beheertekst)
        {
            this.Beheerderid = beheerid;
            this.Postbeheerder = beheertekst;
        }


        public Post(int beheerderid, string post, DateTime date)
        {
            this.Beheerderid = beheerderid;
            this.Postbeheerder = post;
            this.Date = date;
        }
       

    }
}
