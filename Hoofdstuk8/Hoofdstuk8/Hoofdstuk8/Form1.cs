using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoofdstuk8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Daan()
            {
                int getal1 = 5;
                int getal2 = 10;

                int som = (getal1 + getal2);

                lblOutput.Text = som.ToString();
            }

        void Aftrek()
            {
                int getal1 = 5;
                int getal2 = 10;

                int som = (getal1 - getal2);

                lblOutput.Text = som.ToString();
            }

        double som1()
            {
                double getal1 = 12;
                double getal2 = 15;

                double som = (getal1 + getal2);
                return som;
            }

        int som2()
            {
                int getal1 = 4;
                int getal2 = 7;

                int som = (getal1 * getal2);
                return som;
            }

        int optellen(int getal1, int getal2)
            {
                int som = 0;
                som = getal1 + getal2;
                return som;
            }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Daan();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            Aftrek();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            lblOutput.Text = som1().ToString();
        }

        private void btnKeer_Click(object sender, EventArgs e)
        {
            lblOutput.Text = som2().ToString();
        }

        private void btnPara_Click(object sender, EventArgs e)
        {
            lblOutput.Text = optellen(5,10).ToString();
        }
    }
}
