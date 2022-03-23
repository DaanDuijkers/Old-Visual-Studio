using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int beginnummer = Convert.ToInt32(txbBeginnummer.Text);
            int vermenigvuldig = Convert.ToInt32(txbVermenigvuldig.Text);
            
            for(int teller = 1; teller <= vermenigvuldig; teller++)
                {
                    int som = teller * beginnummer;
                    lblOutput.Text = lblOutput.Text + teller + " * " + beginnummer + " = " + som + "\r\n";
                }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            txbBeginnummer.Text = "";
            txbVermenigvuldig.Text = "";
            lblOutput.Text = "";
        }
    }
}
