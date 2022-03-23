using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoothies
{
    class Ingrediënt
    {
        public int Calorieën = 0;
        public string Naam = "";
        public System.Drawing.Color Kleur = System.Drawing.Color.AliceBlue;
        public string LandVanHerkomst = "Nederland";
        public double PrijsPerKilo = 0;

        public Ingrediënt(string naam, System.Drawing.Color kleur, string landVanHerkomst, int calorieën, double PrijsPerKilo)
        {
            this.Naam = naam;
            this.Kleur = kleur;
            this.LandVanHerkomst = landVanHerkomst;
            this.Calorieën = calorieën;
            this.PrijsPerKilo = PrijsPerKilo;
        }

        public Ingrediënt()
        {
            
        }
        
        public override string ToString()
        {
            return "Ingrediënt: " + Naam + " met de kleur " + Kleur + " , het aantal calorieën" +
                Calorieën + " en een prijs per kilo van €" + PrijsPerKilo + " uit " +
                LandVanHerkomst;
        }
    }
}
