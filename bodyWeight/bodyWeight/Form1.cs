using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bodyWeight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int weight = Convert.ToInt32(txbWeight.Text);
                double height = Convert.ToDouble(txbHeight.Text);

                double bmi = weight / (height * height);
                lblBmi.Text = "Your bmi is " + bmi.ToString("0.00");

                if (bmi < 18.5)
                {
                    lblYourWeight.Text = "You are underweight!";
                }
                else if (bmi >= 18.5 && bmi < 25)
                {
                    lblYourWeight.Text = "You are of normal weight!";
                }
                else if (bmi >= 25 && bmi < 30)
                {
                    lblYourWeight.Text = "You are overweight!";
                }
                else
                {
                    lblYourWeight.Text = "You are obese!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
