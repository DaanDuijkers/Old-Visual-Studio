using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class
{
    class BankAccount
    {
        private string client;
        private int accountNo;
        private double balance;

        public void InitializeBankAccount (string newClient, int newAccountNo)
        {
            client = newClient;
            accountNo = newAccountNo;
            balance = 0;
        }

        public void DepositMoney (double amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
        }

        public void WithdrawMoney(double amount)
        {
            if ((balance - amount) < 0)
            {
                MessageBox.Show("You cannot withdraw so much money!");
            }
            else
            {
                balance =- amount;
            }
        }

        public string GetInfo()
        {
            string info = balance.ToString("0.00");
            return info;
        }
    }
}
