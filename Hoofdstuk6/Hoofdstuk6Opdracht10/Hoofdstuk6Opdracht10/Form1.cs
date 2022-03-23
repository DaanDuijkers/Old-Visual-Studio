using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoofdstuk6Opdracht10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            int getal = int.Parse(txbOutput.Text);

            txbOutput.Text = "";

            for(int teller = 1; teller <= 10; teller++)
            {
                int som = teller * getal;
                txbOutput.Text = txbOutput.Text + teller + " X " + getal + " = " + som + "\r\n";
            }
        }
    }
}
