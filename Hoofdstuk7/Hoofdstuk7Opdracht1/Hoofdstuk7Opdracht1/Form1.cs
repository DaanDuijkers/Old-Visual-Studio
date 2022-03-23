using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoofdstuk7Opdracht1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txbBoxInvoer_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txbBoxInvoer_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keychar = e.KeyChar;

            keychar = keychar - 1;

            char c = (char)keychar;

            textBox1.Text = textBox1.Text + c.ToString();
        }
    }
}
