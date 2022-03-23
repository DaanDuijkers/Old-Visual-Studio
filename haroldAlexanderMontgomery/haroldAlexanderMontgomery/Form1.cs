using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace haroldAlexanderMontgomery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbBeer.Checked == true && cbAge.Checked == true)
                {
                    lblResult.Text = "Enjoy your beer!";
                }
                else if (rbBeer.Checked == true && cbAge.Checked == false)
                {
                    lblResult.Text = "Sorry, you are too young.";
                }
                else if (rbLemonade.Checked == true)
                {
                    lblResult.Text = "Enjoy your lemonade!";
                }
                else
                {
                    lblResult.Text = "Make an order, please.";
                }
            }
            catch (Exception ex)
            {
                lblResult.Text = ex.Message;
            }
        }
    }
}
