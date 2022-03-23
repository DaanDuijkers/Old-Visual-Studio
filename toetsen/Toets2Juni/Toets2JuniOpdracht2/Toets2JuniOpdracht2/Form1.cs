using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toets2JuniOpdracht2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUitvoeren_Click(object sender, EventArgs e)
        {
            string roepnaam = txbRoepnaam.Text;
            string achternaam = txbAchternaam.Text;
            int leeftijd = int.Parse(txbLeeftijd.Text);

            lblOutputNaam.Text = roepnaam + " " + achternaam + " " + leeftijd;

            if(leeftijd >= 18)
                {
                    lblOutputLeeftijd.Text = "Drink bier in plaats van water, dan heb je morgen een flinke kater";
                }
                else
                    {
                        lblOutputLeeftijd.Text = "Je mag nog geen alcohol drinken.";
                    }
        }
    }
}
