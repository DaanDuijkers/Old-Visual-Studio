using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore
{
    class Boek
    {
        public int HuidigePagina { private set; get; }
        public string Naam { private set; get; }
        public int AantalPagina { private set; get; }
        public bool Selected { private set; get; }

        public int volgende()
        {
            if (HuidigePagina < AantalPagina)
            {
                return HuidigePagina + 1;
            }
            return HuidigePagina;
        }

        public int vorige()
        {
            if (HuidigePagina > 0)
            {
                return HuidigePagina - 1;
            }
            return HuidigePagina;
        }

        public int snelVorige (int Aantal)
        {
            if ((HuidigePagina + Aantal) > 0)
            {
                return HuidigePagina - Aantal;
            }
            return HuidigePagina;
        }

        public int snelVolgende (int Aantal)
        {
            if ((HuidigePagina + Aantal) < AantalPagina)
            {
                return HuidigePagina + Aantal;
            }
            return HuidigePagina;
        }

        public void setSelected(string naam)
        {
            this.Naam = naam;
        }
    }
}
