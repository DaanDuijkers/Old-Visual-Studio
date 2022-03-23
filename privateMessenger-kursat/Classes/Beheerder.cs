using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace privateMessenger
{
    class Beheerder
    {
        private int beheerderid;
        private string username;
        private string wachtwoord;
        private string naam;
        Chat chat = new Chat();


        public int Beheerderid { get { return this.beheerderid; } set { this.beheerderid = value; } }
        public string Username { get { return this.username; } set { this.username = value; } }
        public string Wachtwoord { get { return this.wachtwoord; } set { this.wachtwoord = value; } }
        public string Naam { get { return this.naam; } set { this.naam = value; } }

      

        public Beheerder()
        {

        }
        public Beheerder(int beheerid)
        {
            this.Beheerderid = beheerderid;
        }

        public Beheerder(int id, string username, string wachtwoord, string naam)
        {
            this.Beheerderid = id;
            this.Username = username;
            this.Wachtwoord = wachtwoord;
            this.Naam = naam;
        }

        public Beheerder(int id, string naam)
        {
            this.Beheerderid = id;
            this.Naam = naam;
     
        }


        public override string ToString()
        {
            return String.Format("Username: {0}  ",username) ; 
        }


        //public string ReadMessage(string message) 
        //{ 

        //}
    }
}
