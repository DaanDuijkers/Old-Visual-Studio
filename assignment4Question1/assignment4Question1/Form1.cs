using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment4Question1
{
    public partial class Form1 : Form
    {
        int n = 0;
        int sum = 0;
        int i = 0;
        int power = 0;
        string stars = string.Empty;
        int teller = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void convert ()
        {
            n = Convert.ToInt32(txbInputNumber.Text);
            sum = 0;
        }

        private void convertStars()
        {
            n = Convert.ToInt32(txbInputNumber.Text);
            string stars = string.Empty;
        }

        private void btnTask1_Click(object sender, EventArgs e)
        {
            convert();

            i = 0;
            while (i <= n)
            {
                sum += i;
                i++;
            }

            txbInputNumber.Text = string.Empty;
            lbOutput.Items.Add("Sum is: " + sum.ToString());
        }

        private void btnTask2_Click(object sender, EventArgs e)
        {
            convert();

            i = 0;
            lbOutput.Items.Add("Sum is: " + sum.ToString());
            i++;

            while (i <= n)
            {
                sum += i;
                lbOutput.Items.Add("Sum is: " + sum.ToString() + ", last added is " + i);
                i++;
            }
            txbInputNumber.Text = string.Empty;
        }

        private void btnTask3_Click(object sender, EventArgs e)
        {
            convert();

            i = 0;
            while (i <= n)
            {
                power = i * i;
                sum += power;
                i++;
            }

            lbOutput.Items.Add("The result is: " + sum.ToString());
            txbInputNumber.Text = string.Empty;
        }

        private void btnTask4_Click(object sender, EventArgs e)
        {
            convertStars();

            i = 1;
            while (i <= n)
            {
                i++;
                stars += "*";
                lbOutput.Items.Add(stars);
            }
        }

        private void btnTask5_Click(object sender, EventArgs e)
        {
            convertStars();

            i = 1;
            while (i <= n)
            {
                stars += "*";
                lbOutput.Items.Add(stars);
                i++;
            }

            while (n > 0)
            {
                stars = string.Empty;

                teller = 1;
                while (teller < n)
                {
                    stars += "*";
                    teller++;
                }

                n--;
                lbOutput.Items.Add(stars);
            }
        }

        private void btnTask6_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(txbInputNumber.Text);
            int p = n;
            int characters = 2 * n - 1;

            for (int teller = 1; teller <= n; teller++)
            {
                stars = string.Empty;

                for (i = 1; i <= characters; i++)
                {
                    if (i == p)
                    {
                        stars += "*";
                    }
                    else
                    {
                        stars += "-";
                    }
                }

                p--;
                lbOutput.Items.Add(stars);
            }
        }
    }
}