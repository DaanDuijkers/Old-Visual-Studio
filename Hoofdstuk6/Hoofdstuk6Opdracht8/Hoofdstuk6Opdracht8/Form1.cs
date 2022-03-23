using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoofdstuk6Opdracht8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            int getal = int.Parse(txbGetal.Text);

            int teller = 0;
            int plus = teller + 1;
            int telop = 1;
            while (telop <= getal)
                {
                    int som = teller + plus;
                    lblOutput.Text = lblOutput.Text + teller + " + " + plus + " = " 
                        + som.ToString() + "\r\n";
                    teller = plus;
                    plus = som;
                    telop++;
                }
        }
    }
}
