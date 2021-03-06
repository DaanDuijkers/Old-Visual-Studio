using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoofdstuk_4_instructie_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBreuk_Click(object sender, EventArgs e)
        {
            // initialisatie variebele
            double getal = 0;
            double breuk = 0;
            // toekenning van waarden / berekeningen
            try
                {
                    getal = double.Parse(txbGetal.Text);
                    breuk = 1 / getal;

                    errorProvider1.SetError(txbGetal, "");
                }
                catch (Exception exception)
                    {
                        errorProvider1.SetError(txbGetal, exception.Message);
                    }
            // tonen van de uitkomst
            MessageBox.Show("De breuk van " + getal.ToString() + " is: " + breuk.ToString());
        }
    }
}
