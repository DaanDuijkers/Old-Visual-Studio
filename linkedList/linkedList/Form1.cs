using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linkedList
{
    public partial class Form1 : Form
    {
        private LinkedMessageSystem lms;

        public Form1()
        {
            InitializeComponent();

            lms = new LinkedMessageSystem();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbSender.Text != string.Empty && txbMessage.Text != string.Empty)
            {
                lms.AddMessage(txbSender.Text, txbMessage.Text);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txbID.Text != string.Empty)
            {
                bool success = lms.RemoveMessageByID(Convert.ToInt32(txbID.Text));

                if (success == true)
                {
                    MessageBox.Show("Message with id " + txbID.Text + " was successfully removed");
                }
                else
                {
                    MessageBox.Show("Message with id " + txbID.Text + " not found");
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txbID.Text != string.Empty)
            {
                ChatMessage c = lms.FindByID(Convert.ToInt32(txbID.Text));

                if (c != null)
                {
                    MessageBox.Show("ID: " + c.GetID() + " Message: " + c.GetMessage() + " Sender: " + c.GetSender());
                }
                else
                {
                    MessageBox.Show("Message with id " + txbID.Text + " not found");
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lbMessages.Items.Clear();
            string[] messages = lms.GetAllMessages();
            foreach (string s in messages)
            {
                lbMessages.Items.Add(s);
            }
        }
    }
}
