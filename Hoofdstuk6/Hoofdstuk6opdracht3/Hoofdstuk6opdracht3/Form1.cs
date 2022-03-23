using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoofdstuk6opdracht3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txbOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            int teller = int.Parse(txbOutput.Text);

            txbOutput.Text = teller.ToString() + "\r\n";
            teller++;

            while (teller <= 250)
            {
                txbOutput.Text = txbOutput.Text + teller.ToString() + "\r\n";
                teller++;
            }
        }
    }
}
