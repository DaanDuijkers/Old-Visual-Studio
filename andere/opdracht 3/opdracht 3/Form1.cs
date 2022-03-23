using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opdracht_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            //andere oplossing: lblOutput.Text = txtVNaam.Text + " " + txtANaam.Text;

            string vnaam = txtVNaam.Text;
            string anaam = txtANaam.Text;

            lblOutput.Text = vnaam + " " + anaam;
        }
    }
}
