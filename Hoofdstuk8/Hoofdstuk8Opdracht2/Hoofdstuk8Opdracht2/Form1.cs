using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoofdstuk8Opdracht2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double RekenUit()
            {
                double getal1 = double.Parse(txbLengte.Text);
                double getal2 = double.Parse(txbBreedte.Text);
                double som = getal1 * getal2;
                return som;
            }

        private void btnRekenUit_Click(object sender, EventArgs e)
        {
            lblOutput.Text = RekenUit().ToString();
        }
    }
}
