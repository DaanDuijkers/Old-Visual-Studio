using bankAccount.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankAccount
{
    public partial class Form1 : Form
    {
        List<Bankaccount> accountList = new List<Bankaccount> ();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            Bankaccount account = new Bankaccount();

            string name = txbName.Text;
            int accountNr = Convert.ToInt32(txbAccountNr.Text);
            double startingAmount = Convert.ToDouble(txbStartingAmount.Text);
            account.setAccount(name, accountNr, startingAmount);

            accountList.Add(account);
        }
    }
}