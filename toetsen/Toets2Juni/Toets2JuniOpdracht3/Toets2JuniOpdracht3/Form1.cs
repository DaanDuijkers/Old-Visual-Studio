using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toets2JuniOpdracht3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUitvoeren_Click(object sender, EventArgs e)
        {
            double getal1 = double.Parse(txbGetal1.Text);
            double getal = double.Parse(txbGetal.Text);

            string Operator = txbOperator.Text;

            if(Operator == "/")
                {
                    double som = getal1 / getal;

                    lblOutput.Text = som.ToString();
                }
                else if(Operator == "+")
                    {
                        double som = getal1 + getal;

                        lblOutput.Text = som.ToString();
                    }
                    else if(Operator == "-")
                        {
                            double som = getal1 - getal;

                            lblOutput.Text = som.ToString();
                        }
                        else if(Operator == "*")
                            {
                                double som = getal1 * getal;

                                lblOutput.Text = som.ToString();
                            }
        }
    }
}
