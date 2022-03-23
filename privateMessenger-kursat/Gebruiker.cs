using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace privateMessenger
{
    class Gebruiker
    {
        private string gebruikerid = "";
        private string gebruikersnaam = "";

        public string Gebruikerid { get { return this.gebruikerid; } set { this.gebruikerid = value; } }
        public string Gebruikersnaam { get { return this.gebruikersnaam; } set { this.gebruikersnaam = value; } }

        public Gebruiker() { }

        public Gebruiker(string gebruikerid) 
        {
            this.Gebruikerid = gebruikerid;
        }

        public override string ToString()
        {
            return  String.Format("Id: {0}  ", this.Gebruikerid);
        }
       
    }
}
