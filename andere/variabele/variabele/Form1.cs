using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace variabele
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnclick_Click(object sender, EventArgs e)
        {
            string naam = " Daan";
            string gilde = " Gilde Opleidingen leeftijd: ";
            int leeftijd = 21;
            lblOutput.Text = naam + gilde + leeftijd;
        }
    }
}
