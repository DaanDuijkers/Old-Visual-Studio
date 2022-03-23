using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toets2Opdracht1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            try
            {
                double getal1 = double.Parse(txbGetal1.Text);
                double getal2 = double.Parse(txbGetal2.Text);

                if (txbBerekening.Text == "+")
                {
                    double som = getal1 + getal2;

                    lblOutput.Text = som.ToString();
                }
                else if (txbBerekening.Text == "-")
                {
                    double som = getal1 - getal2;

                    lblOutput.Text = som.ToString();
                }
                else if (txbBerekening.Text == "*")
                {
                    double som = getal1 * getal2;

                    lblOutput.Text = som.ToString();
                }
                else if (txbBerekening.Text == "/")
                {
                    double som = getal1 / getal2;

                    lblOutput.Text = som.ToString();
                }
                else
                {
                    lblOutput.Text = "Fout invoer";
                }
            }
            catch
            {
                lblOutput.Text = "Fout invoer";
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txbGetal1.Text = String.Empty;
            txbGetal2.Text = String.Empty;
            txbBerekening.Text = String.Empty;
        }
    }
}
