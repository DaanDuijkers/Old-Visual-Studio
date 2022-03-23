using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lucasNumbers
{
    public partial class Form1 : Form
    {
        int n;
        int firstNumber;
        int secondNumber;
        int conclusion;

        public Form1()
        {
            InitializeComponent();
        }

        private void convert()
        {
            n = Convert.ToInt32(txbInputNumber.Text);
        }

        private void btnTask1_Click(object sender, EventArgs e)
        {
            convert();

            for (int i = 1; i <= n; i++)
            {
                if (i == 1)
                {
                    firstNumber = 2;
                    lbOutput.Items.Add(firstNumber.ToString());
                }
                else if (i == 2)
                {
                    secondNumber = 1;
                    lbOutput.Items.Add(secondNumber.ToString());
                }
                else
                {
                    conclusion = firstNumber + secondNumber;
                    lbOutput.Items.Add(conclusion.ToString());
                    firstNumber = secondNumber;
                    secondNumber = conclusion;
                }
            }
        }

        private void btnTask2_Click(object sender, EventArgs e)
        {
            convert();

            firstNumber = 2;
            secondNumber = 0;
            conclusion = firstNumber + secondNumber;

            conclusion = 2;
            while (conclusion < n)
            {
                lbOutput.Items.Add(conclusion.ToString());

                if (conclusion == 2)
                {
                    secondNumber = 1;
                    conclusion = 1;
                }
                else
                {
                    conclusion = firstNumber + secondNumber;
                    firstNumber = secondNumber;
                    secondNumber = conclusion;
                }
            }
        }

        private void btnTask3_Click(object sender, EventArgs e)
        {
            convert();
            int end = n + 100;
            int sum = 0;

            for (int i = n; i < end; i++)
            {
                if (i % 9 == 0)
                {
                    lbOutput.Items.Add(i.ToString());
                    sum += i;
                }
            }

            lbOutput.Items.Add("Sum is " + sum.ToString());
        }
    }
}
