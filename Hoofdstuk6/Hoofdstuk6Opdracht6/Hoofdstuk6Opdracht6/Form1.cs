using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoofdstuk6Opdracht6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUitkomst_Click(object sender, EventArgs e)
        {
            int teller = 1;
            double getal = double.Parse(txbGetal.Text);
            int Int = int.Parse(txbInt.Text);

            double som = getal * getal;
            string extra = "";
            while (teller <= Int)
                {
                    lblOutput.Text = lblOutput.Text + getal + " X " + getal + extra + " = " 
                        + som + "\r\n";
                    som = som * getal;
                    extra = extra + " X " + getal;
                    teller++;
                }
        }
    }
}
