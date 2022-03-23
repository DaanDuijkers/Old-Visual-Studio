using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToetsOefening6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUitkomst_Click(object sender, EventArgs e)
        {
            string voornaam = txbVoornaam.Text;
            string achternaam = txbAchternaam.Text;

            double engels = double.Parse(txbEngels.Text);
            double nederlands = double.Parse(txbNederlands.Text);
            double ao = double.Parse(txbAO.Text);
            double ia = double.Parse(txbIA.Text);

            double gemiddeld = engels + nederlands + ao + ia / 4;

            lblUitkomst.Text = voornaam + " " + achternaam + "\nEngels:" + engels.ToString() + 
            "\nNederlands: " + nederlands.ToString() + "\nAO: " + ao + "\nIA: " + ia + 
            "\ngemiddelde: " + gemiddeld;
        }
    }
}
