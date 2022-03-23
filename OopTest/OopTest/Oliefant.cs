using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopTest
{
    class Oliefant
    {
        public string Kleur { private set; get; }
        public string Naam { private set; get; }

        public void setKleur(string Kleur)
        {
            this.Kleur = Kleur;
        }

        public void setNaam(string Naam)
        {
            this.Naam = Naam;
        }

        public string Loop()
        {
            return "Olifant " + this.Naam + " loopt";
        }

        public string Stop()
        {
            return "Olifant " + this.Naam + " stopt";
        }

        public string Eet()
        {
            return "Olifant " + this.Naam + " eet";
        }
    }
}
