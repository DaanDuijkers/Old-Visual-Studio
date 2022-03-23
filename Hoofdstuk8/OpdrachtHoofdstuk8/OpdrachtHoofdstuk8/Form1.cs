using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpdrachtHoofdstuk8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        void user()
            {
            string roepnaam = txbRoepnaam.Text;
            string achternaam = txbAchternaam.Text;
            int leeftijd = int.Parse(txbLeeftijd.Text);
            lblUser.Text = roepnaam + " " + achternaam + " " + leeftijd;
            }

        void ageCheck()
            {
                int leeftijd = int.Parse(txbLeeftijd.Text);
                if (leeftijd >= 18)
                {
                    lblCheck.Text = "Drink bier in plaats van water, dan heb je morgen een flinke kater";
                }
                else
                    {
                        lblCheck.Text = "Je mag nog geen alcohol drinken";
                    }
            }

        void print()
            {
            string roepnaam = txbRoepnaam.Text;
            string achternaam = txbAchternaam.Text;
            int leeftijd = int.Parse(txbLeeftijd.Text);
            for (int teller = 1; teller <= 10; teller++)
                    {
                        lblLoop.Text = lblLoop.Text + roepnaam + " " + achternaam + " " + leeftijd + "\r\n";
                    }
        }

        private void btnUitvoeren_Click(object sender, EventArgs e)
        {
            user();
            ageCheck();
            print();
        }
    }
}
