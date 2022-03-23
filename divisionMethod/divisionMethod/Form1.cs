using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace divisionMethod
{
    public partial class Form1 : Form
    {
        double number1;
        double number2;

        public Form1()
        {
            InitializeComponent();
        }

        double calculate (double number1, double number2)
        {
            double result = number1 / number2;

            return result;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = Convert.ToDouble(txbNumber1.Text);
                number2 = Convert.ToDouble(txbNumber2.Text);

                txbResult.Text = calculate(number1, number2).ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
