using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dieren
{
    class oliefant
    {
        String _naam;

        public oliefant(string naam)
        {
            _naam = naam;
        }

        public string naamDier()
        {
            return "Dit dier heet " + _naam;
        }
    }
}
