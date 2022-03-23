using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opdracht23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBerekenOppervlakte_Click(object sender, EventArgs e)
        {
            double lengte = Convert.ToDouble(txbLengte.Text);
            double breedte = Convert.ToDouble(txbBreedte.Text);

            double som = lengte * breedte;

            lblOutput.Text = som.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            txbLengte.Text = "";
            txbBreedte.Text = "";
            lblOutput.Text = "";
        }
    }
}
