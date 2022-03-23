using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class
{
    public partial class Form1 : Form
    {
        BankAccount checking = new BankAccount();
        BankAccount savings = new BankAccount();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(txbAmount.Text);
            txbAmount.Text = string.Empty;

            if (rbCheckingAccount.Checked)
            {
                checking.DepositMoney(amount);

                string check = checking.GetInfo();
                lblCheckingBalance.Text = check;
            }
            else
            {
                savings.DepositMoney(amount);

                string check = savings.GetInfo();
                lblSavingsBalance.Text = check;
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(txbAmount.Text);
            txbAmount.Text = string.Empty;

            if (rbCheckingAccount.Checked)
            {
                checking.WithdrawMoney(amount);

                string check = checking.GetInfo();
                lblCheckingBalance.Text = check;
            }
            else
            {
                savings.WithdrawMoney(amount);

                string check = savings.GetInfo();
                lblSavingsBalance.Text = check;
            }
        }
    }
}
