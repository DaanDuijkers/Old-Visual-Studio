using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoofdstuk3string
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string voornaam = txtVoornaam.Text;
            string achternaam = txtAchternaam.Text;
            int leeftijd = Convert.ToInt32(txtLeeftijd.Text);

            lblOutput.Text = voornaam + " " + achternaam + ", " + leeftijd + " jaar oud.";
        }
    }
}
