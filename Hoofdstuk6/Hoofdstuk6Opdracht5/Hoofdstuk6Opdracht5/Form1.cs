using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoofdstuk6Opdracht5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUitkomst_Click(object sender, EventArgs e)
        {
            int teller = 0;
            int getal1 = int.Parse(txbGetal1.Text);
            int getal2 = int.Parse(txbGetal2.Text);
            
            while (teller <= getal1)
            {
                int som = teller * getal2;
                lblOutput.Text = lblOutput.Text + teller + " x " + getal2 + " = " + som + "\r\n";
                teller++;
            }
        }
    }
}
