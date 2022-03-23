using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoofdstruk3variabelen
{
    public partial class Form1 : Form
    {
        double getal1;
        double getal2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getal1 = Convert.ToDouble(txtGetal1.Text);
            getal2 = Convert.ToDouble(txtGetal2.Text);

            lblOutput.Text = "De som van " + getal1 + " + " + getal2 + " is " + Convert.ToString(getal1 + getal2);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int getal = 2;

            lblOutput.Text = "De som van " + getal + " + " + getal + " = " + Convert.ToString(getal + getal);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            double min1 = Convert.ToDouble(txtMin1.Text);
            double min2 = Convert.ToDouble(txtMin2.Text);

            lblUitkomst.Text = "De som van " + min1 + " - " + min2 + " = " + Convert.ToString(min1 - min2);
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnKeer_Click(object sender, EventArgs e)
        {
            double keer1 = Convert.ToDouble(txtKeer1.Text);
            double keer2 = Convert.ToDouble(txtKeer2.Text);

            lblKeer.Text = "De som van " + keer1 + " x " + keer2 + " = " + Convert.ToString(keer1 * keer2);
        }

        private void btnDeel_Click(object sender, EventArgs e)
        {
            double deel1 = Convert.ToDouble(txtDeel1.Text);
            double deel2 = Convert.ToDouble(txtDeel2.Text);

            lblDeel.Text = "De som van " + deel1 + " : " + deel2 + " = " + Convert.ToString(deel1 / deel2);
        }
    }
}
