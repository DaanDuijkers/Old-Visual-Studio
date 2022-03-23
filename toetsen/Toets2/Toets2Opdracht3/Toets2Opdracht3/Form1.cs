using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toets2Opdracht3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFactuur_Click(object sender, EventArgs e)
        {
            string voornaam = txbVoornaam.Text;
            string achternaam = txbAchternaam.Text;
            string artikel1 = txbArtikel1.Text;
            string artikel2 = txbArtikel2.Text;
            int aantal1 = int.Parse(txbAantal1.Text);
            int aantal2 = int.Parse(txbAantal2.Text);

            double bedrag1 = aantal1 * 13.59;
            double bedrag2 = aantal2 * 35.11;
            double subtotaal = bedrag1 + bedrag2;
            double btw = subtotaal * 0.21;
            double totaalBedrag = subtotaal + btw;

            lblOutput.Text = "U naam is: " + voornaam + " " + achternaam + "\r\n" +
                "Artikel 1: " + artikel1 + " Aantal: " + aantal1 + " bedrag: " + bedrag1 + "\r\n" +
                "Artikel 2: " + artikel2 + " Aantal: " + aantal2 + " bedrag: " + bedrag2 + "\r\n" +
                "Subtotaal: " + subtotaal + "\r\n" +
                "BTW Bedrag: " + btw + "\r\n" +
                "Totaal bedrag: " + totaalBedrag;
        }
    }
}
