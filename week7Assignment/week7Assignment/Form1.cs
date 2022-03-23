using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week7Assignment
{
    public partial class Form1 : Form
    {
        int[] numbers = new int[6] { 0, 0, 0, 0, 0, 0 };
        double[] values = new double[6] { 0.05, 0.10, 0.20, 0.50, 1.00, 2.00 };
        double[] sum = new double[6];

        public Form1()
        {
            InitializeComponent();
        }

        private void ShowInfoOfMoneyBox(int i)
        {
            try
            {
                string outcome = CoinInfo(i);
                lbArray.Items.RemoveAt(i);
                lbArray.Items.Insert(i, outcome);

                double total = CoinTotal();
                txbTotal.Text = "€" + total.ToString("0.00");

                txbAmount.Text = 1.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string CoinInfo(int i)
        {
            double value = values[i];
            int times = numbers[i] += Convert.ToInt32(txbAmount.Text);
            double total = values[i] * times;
            sum[i] = total;

            string outcome = "€" + value.ToString("0.00") + "\t" + times + "\t€" + total.ToString("0.00");
            return outcome;
        }

        private double CoinTotal()
        {
            double total = 0;

            for (int i = 0; i < 6; i++)
            {
                total += sum[i];
            }

            return total;
        }

        private void btn005_Click(object sender, EventArgs e)
        {
            ShowInfoOfMoneyBox(0);
        }

        private void btn010_Click(object sender, EventArgs e)
        {
            ShowInfoOfMoneyBox(1);
        }

        private void btn020_Click(object sender, EventArgs e)
        {
            ShowInfoOfMoneyBox(2);
        }

        private void btn050_Click(object sender, EventArgs e)
        {
            ShowInfoOfMoneyBox(3);
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            ShowInfoOfMoneyBox(4);
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            ShowInfoOfMoneyBox(5);
        }
    }
}
