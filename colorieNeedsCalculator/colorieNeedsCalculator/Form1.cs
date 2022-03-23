using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colorieNeedsCalculator
{
    public partial class Form1 : Form
    {
        double weight;
        double length;
        double age;
        double BMR;

        public Form1()
        {
            InitializeComponent();

            rbMan.Checked = true;
            rbSedentary.Checked = true;
        }

        private void BtnBMR_Click(object sender, EventArgs e)
        {
            if (rbMan.Checked)
            {
                BMR = 88.362;

                weight = Convert.ToDouble(txbWeight.Text);
                weight *= 13.397;

                length = Convert.ToDouble(txbLength.Text);
                length *= 4.799;

                age = Convert.ToInt32(txbAge.Text);
                age *= 5.677;

                BMR += weight + length - age;
                BMR = Convert.ToInt32(BMR);
                lblBmrValue.Text = "The BMR value is " + BMR.ToString();
            }
            else
            {
                BMR = 447.593;

                weight = Convert.ToDouble(txbWeight.Text);
                weight *= 9.247;

                length = Convert.ToDouble(txbLength.Text);
                length *= 3.098;

                age = Convert.ToInt32(txbAge.Text);
                age *= 4.330;

                BMR += weight + length - age;
                BMR = Convert.ToInt32(BMR);
                lblBmrValue.Text = "The BMR value is " + BMR.ToString();
            }
        }

        private void CheckInput (KeyPressEventArgs e)
        {
            char chr = e.KeyChar;

            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("This textbox only accepts numbers.");
            }
        }

        private void txbWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput(e);
        }

        private void txbLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput(e);
        }

        private void txbAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput(e);
        }

        private void btnCalorieNeeds_Click(object sender, EventArgs e)
        {
            if (lblBmrValue.Text != string.Empty)
            {
                if (rbSedentary.Checked)
                {
                    BMR *= 1.2;
                }
                else if (rbLightlyActive.Checked)
                {
                    BMR *= 1.375;
                }
                else if (rbModeratelyActive.Checked)
                {
                    BMR *= 1.55;
                }
                else if (rbVeryActive.Checked)
                {
                    BMR *= 1.725;
                }
                else
                {
                    BMR *= 1.9;
                }

                BMR = Convert.ToInt32(BMR);
                lblDailyCalorieNeeds.Text = "Daily Calorie Needs: " +  BMR.ToString() + "(kcal)";
            }
            else
            {
                MessageBox.Show ("Please calculate the Basal Metabolic Rate (BMR) first");
            }
        }
    }
}
