using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1FirstForm
{
    public partial class Form1 : Form
    {
        int graduatingAge;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            if (txbName.Text != string.Empty && txbAge.Text != string.Empty)
            {
                graduatingAge = Convert.ToInt32(txbAge.Text) + 4;
                lblResult.Text = txbName.Text + ", you will be " + graduatingAge + " when you graduate.";

                txbName.Text = string.Empty;
                txbAge.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Please enter information into the textboxes.");
                lblResult.Text = string.Empty;
            }
        }
    }
}
