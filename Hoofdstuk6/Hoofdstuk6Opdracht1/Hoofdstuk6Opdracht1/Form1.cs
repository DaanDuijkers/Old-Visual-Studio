using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoofdstuk6Opdracht1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            txbOutcome.Text = txbOutcome.Text + 50 + "\r\n";
            txbOutcome.Text = txbOutcome.Text + 51 + "\r\n";
            txbOutcome.Text = txbOutcome.Text + 52 + "\r\n";
            txbOutcome.Text = txbOutcome.Text + 53 + "\r\n";
            txbOutcome.Text = txbOutcome.Text + 54 + "\r\n";
            txbOutcome.Text = txbOutcome.Text + 55 + "\r\n";
            txbOutcome.Text = txbOutcome.Text + 56 + "\r\n";
            txbOutcome.Text = txbOutcome.Text + 57 + "\r\n";
            txbOutcome.Text = txbOutcome.Text + 58 + "\r\n";
            txbOutcome.Text = txbOutcome.Text + 59 + "\r\n";
            txbOutcome.Text = txbOutcome.Text + 60 + "\r\n";
        }
    }
}
