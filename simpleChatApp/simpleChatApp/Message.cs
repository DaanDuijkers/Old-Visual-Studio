using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleChatApp
{
    public class Message
    {
        public string Text { get; set; }
        public string Sender { get; set; }

        public Message (string sender, string text)
        {
            this.Text = text;
            this.Sender = sender;
        }

        public override string ToString()
        {
            return $"{Sender}: {Text}";
        }
    }
}