using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoofdstuk6Opdracht7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            int teller = 1;
            double getal = double.Parse(txbGetal.Text);
            
            while (teller <= getal)
            {
                int som = teller;
                lblOutput.Text = lblOutput.Text + som.ToString() + " x ";
                teller++;
            }
            lblOutput.Text = lblOutput.Text + " = ";
        }
    }
}
