using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpdrachtVariabelen1InvoerGetallen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtGetal1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte getal1 = byte.Parse(txtGetal1.Text);
            sbyte getal2 = sbyte.Parse(txtGetal2.Text);
            lblGetal1.Text = Convert.ToString(getal1 + getal2);
        }
    }
}
