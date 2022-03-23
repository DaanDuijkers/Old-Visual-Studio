using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toets2JuniOpdracht1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUitvoeren_Click(object sender, EventArgs e)
        {
            int getal1 = 100;
            double getal2 = 10.52;
            double getal3 = 4.48;

            double som = getal1 + getal2 + getal3;

            lblOutcome.Text = "De som van " + getal1 + " + " + getal2 + " + " + getal3 + 
                " = " + som;
        }
    }
}
