using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToetsOefening5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFactuur_Click(object sender, EventArgs e)
        {
            try
                {
                    string voornaam = txbVoornaam.Text;
                    string achternaam = txbAchternaam.Text;
                    string artikel1 = txbArtikel1.Text;
                    string artikel2 = txbArtikel2.Text;

                    double bedrag1 = int.Parse(txbAantal1.Text) * 13.59;
                    double bedrag2 = int.Parse(txbAantal2.Text) * 35.11;

                    double subtotaal = bedrag1 + bedrag2;
                    double btw = subtotaal * 0.21;
                    double factuurbedrag = subtotaal + btw;
                

            lblOutcome.Text = "Klant: " + voornaam + " " + achternaam +

                        "\n\nArtikel: " + artikel1 + "; Prijs per stuk: €13.59; Prijs in totaal: €" +
                        bedrag1 +
                        "\nArtikel: " + artikel2 + "; Prijs per stuk: €35.11; Prijs in totaal: €" +
                        bedrag2 +

                        "\n\nSubtotaal: €" + subtotaal +

                        "\n\nBTW: €" + btw +

                        "\n\nFactuurbedrag: €" + factuurbedrag;
                }
                catch
                    {
                        MessageBox.Show("U heeft iets niet of fout ingevult");
                    }
        }
    }
}
