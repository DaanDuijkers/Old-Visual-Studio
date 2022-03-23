using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ageChecker
{
    public partial class Form1 : Form
    {
        int age;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                age = Convert.ToInt32(txbAge.Text);

                if (age >= 18)
                {
                    lblResult.Text = "You age old enough, enjoy your beverage!";
                }
                else
                {
                    lblResult.Text = "Sorry, you are not old enough.";
                }
            }
            catch(Exception ex)
            {
                lblResult.Text = ex.Message;
            }
        }
    }
}
