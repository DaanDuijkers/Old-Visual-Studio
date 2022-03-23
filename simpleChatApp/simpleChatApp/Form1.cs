using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleChatApp
{
    partial class Form1 : Form
    {
        private MessageRelayHub messageRelayHub;
        private string senderName;

        public Form1()
        {
            InitializeComponent();

            this.messageRelayHub = new MessageRelayHub();
            this.messageRelayHub.NewMessage += DisplayNewMessage;
            this.senderName = "Sender";

            Form other = new Form1(this.messageRelayHub, "Sarrah");
            other.Show();
            other = new Form1(this.messageRelayHub, "Jane");
            other.Show();
            other = new Form1(this.messageRelayHub, "Lily");
            other.Show();
        }

        public Form1 (MessageRelayHub messageRelayHub, string senderName)
        {
            InitializeComponent();

            this.messageRelayHub = messageRelayHub;
            this.messageRelayHub.NewMessage += DisplayNewMessage;
            this.senderName = senderName;
        }

        private void DisplayNewMessage (Message message)
        {
            lbMessages.Items.Add(message);
        }

        private void txbText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txbText.Text))
                {
                    this.messageRelayHub.SendMessage(new Message(senderName, txbText.Text));

                    txbText.Clear();
                }
            }
        }
    }
}
