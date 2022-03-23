using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opdracht_4
{
    public partial class Form1 : Form
    {
        int varA = 10; //int voor hele getallen
        double varB = 20.50; //double voor komma getallen
        double varC = 50.10;
        int varD = 20;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double uitkomst = varA + varB + varC + varD;

            lblUitkomst.Text = uitkomst.ToString();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            double uitkomst = varA - varB - varC - varD;

            lblUitkomst.Text = uitkomst.ToString();
        }

        private void btnKeer_Click(object sender, EventArgs e)
        {
            double uitkomst = varA * varB * varC * varD;

            lblUitkomst.Text = uitkomst.ToString();
        }

        private void btnDeel_Click(object sender, EventArgs e)
        {
            double uitkomst = varA / varB / varC / varD;

            lblUitkomst.Text = uitkomst.ToString();
        }
    }
}
