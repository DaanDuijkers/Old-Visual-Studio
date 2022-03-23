using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoofdstuk6ExtraOpdracht2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double cel()
            {
                double fah = double.Parse(txbFah.Text);
                double som = (fah - 32) / 1.8;
                return som;
            }

        double fah()
            {
                double cel = double.Parse(txbCel.Text);
                double som = (cel * 1.8) + 32;
                return som;
            }

        private void btnFah_Click(object sender, EventArgs e)
        {
            lblFah.Text = fah().ToString();
        }

        private void btnCel_Click(object sender, EventArgs e)
        {
            lblCel.Text = cel().ToString();
        }
    }
}
