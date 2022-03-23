using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toets2Opdracht2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txbRoepnaam.Text = String.Empty;
            txbAchternaam.Text = String.Empty;
            txbLeeftijd.Text = String.Empty;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                string roepnaam = txbRoepnaam.Text;
                string achternaam = txbAchternaam.Text;
                int leeftijd = int.Parse(txbLeeftijd.Text);

                lblAgeCheck.Text = roepnaam + " " + achternaam + " " + leeftijd;

                if (leeftijd >= 18)
                {
                    lblBier.Text = "Drink hier bier in plaats van water, dan heb je morgen " +
                        "een flinke kater";
                }
                else
                {
                    lblBier.Text = "Je mag nog geen bier drinken";
                }

                for (int teller = 1; teller <= 10; teller++)
                {
                    int som = teller * 7;
                    lblTafel.Text = lblTafel.Text + teller + " * 7 = " + som + "\r\n";
                }
            }
            catch
            {
                MessageBox.Show("Fout invoer");
            }
        }
    }
}
