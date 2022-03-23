using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int firstNumber;
        int secondNumber;
        int result;

        public Form1()
        {
            InitializeComponent();
        }

        private void Answer ()
        {
            lblAnswer.Text = "The answer is " + result.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToInt32(txbFirstNumber.Text);
            secondNumber = Convert.ToInt32(txbSecondNumber.Text);

            result = firstNumber + secondNumber;

            Answer();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToInt32(txbFirstNumber.Text);
            secondNumber = Convert.ToInt32(txbSecondNumber.Text);

            result = firstNumber - secondNumber;

            Answer();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToInt32(txbFirstNumber.Text);
            secondNumber = Convert.ToInt32(txbSecondNumber.Text);

            result = firstNumber * secondNumber;

            Answer();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToInt32(txbFirstNumber.Text);
            secondNumber = Convert.ToInt32(txbSecondNumber.Text);

            result = firstNumber / secondNumber;

            Answer();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            btnHide.Visible = true;
            txbInfo.Visible = true;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            btnHide.Visible = false;
            txbInfo.Visible = false;
        }
    }
}
