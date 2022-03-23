using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace omzetten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int getal1 = 10;

            lblOutput.Text = Convert.ToString(getal1) + " " + (getal1).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
