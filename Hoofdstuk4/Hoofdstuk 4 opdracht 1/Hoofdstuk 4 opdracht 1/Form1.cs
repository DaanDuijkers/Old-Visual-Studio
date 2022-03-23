using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoofdstuk_4_opdracht_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            try
                {
                    byte getal1 = byte.Parse(txtGetal1.Text);
                    sbyte getal2 = sbyte.Parse(txtGetal2.Text);
                    lblGetal1.Text = Convert.ToString(getal1 + getal2);
                }
                catch (Exception exception)
                    {
                        MessageBox.Show("Er is een fout opgetreden. " + exception.Message);
                    }
        }
    }
}
