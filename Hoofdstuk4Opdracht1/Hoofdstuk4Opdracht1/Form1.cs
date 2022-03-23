using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoofdstuk4Opdracht1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRekenUit_Click(object sender, EventArgs e)
        {
            double getal1 = 0;
            double getal2 = 0;

            try
                {
                    getal1 = double.Parse(txbGetal1.Text);
                    getal2 = double.Parse(txbGetal2.Text);
                    double reken = getal1 + getal2;
                    lblUitvoer.Text = reken.ToString();
                }
                catch(Exception exception)
                    {
                        MessageBox.Show("Er is een fout opgetreden. " + exception.Message);
                    }
        }
    }
}
