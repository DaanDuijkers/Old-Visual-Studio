using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opdracht8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string naam = txbNaam.Text;
            string achternaam = txbAchternaam.Text;
            double spaarbedrag = Convert.ToDouble(txbSpaarbedrag.Text);

            if(spaarbedrag <= 10000)
                {
                    double rente = spaarbedrag * 0.015;
                    lblOutput.Text = naam + " " + achternaam + "\r\n" +
                        "U ontvangt voor een spaar bedrag van €" + spaarbedrag + " aan rente: €" + rente;
                }
                else
                    {
                        double rente = spaarbedrag * 0.02;
                        lblOutput.Text = naam + " " + achternaam + "\r\n" +
                            "U ontvangt voor een spaar bedrag van €" + spaarbedrag + " aan rente: €" + rente;
                    }

            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            txbNaam.Text = "";
            txbAchternaam.Text = "";
            txbSpaarbedrag.Text = "";
            lblOutput.Text = "";
        }
    }
}
