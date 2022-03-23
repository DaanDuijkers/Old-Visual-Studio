using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week6Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFirstAssignment_Click(object sender, EventArgs e)
        {
            double a = 10.8;
            double b = 12.2;
            double sum = a + b;

            sum /= 2;

            if (sum < 40)
            {
                sum -= Math.Min(a, b);
                MessageBox.Show(Math.Min(a, b).ToString());
            }

            MessageBox.Show("The GL value of " + a + " and " + b + " is: " + sum);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                int baseNumber = Convert.ToInt32(tbBase.Text);
                int firstIncrement = Convert.ToInt32(tbIncrement.Text);
                int number = firstIncrement;

                lbInfo.Items.Add("starting");
                lbInfo.Items.Add(baseNumber);
                for (int i = 1; i <= firstIncrement; i++)
                {
                    baseNumber += number;
                    lbInfo.Items.Add(baseNumber);
                    number--;
                }

                lbInfo.Items.Add("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
