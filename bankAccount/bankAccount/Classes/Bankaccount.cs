using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankAccount.Classes
{
    class Bankaccount
    {
        private string username;
        private int accountNumber;
        private double balance;

        public void setAccount (string name, int number, double amount)
        {
            username = name;
            accountNumber = number;
            balance = amount;
        }

        public string getAccount ()
        {
            string account = username + " (" + accountNumber + "): " + balance;
            return account;
        }

        public void deposit (double amount)
        {
            balance =+ amount;
        }

        public void withdraw (double amount)
        {
            balance =- amount;
        }
    }
}