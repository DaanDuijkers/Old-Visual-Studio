using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooptwee
{
    class olifant
    {
        public string Kleur { private set; get; }
        public string Naam { private set; get; }

        public void setKleur(string kleur)
        {
            this.Kleur = kleur;
        }

        public void setNaam(string naam)
        {
            this.Naam = naam;
        }

        public string loop()
        {
            return "Olifant " + this.Naam + " loopt";
        }

        public string stop()
        {
            return "Olifant " + this.Naam + " is gestopt met lopen";
        }

        public string eet(string product)
        {
            return "Olifant " + this.Naam + " eet " + product;
        }

    }
}
