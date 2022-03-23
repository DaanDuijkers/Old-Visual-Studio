using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dieren
{
    class dieren
    {
        String _naam;
        string _kleur;
        string _oogkleur;

        public dieren(string naam, string kleur, string oogkleur)
        {
            _naam = naam;
            _kleur = kleur;
            _oogkleur = oogkleur;
        }

        public string gaEten()
        {
            return "Dit " + _kleur + " " + _naam + " gaat nu eten" + _oogkleur;
        }
    }
}
