using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedList
{
    public class ChatMessage
    {
        private int id;
        private string sender;
        private string message;
        private ChatMessage next;

        public ChatMessage Next { get { return next; } set { next = value; } }

        public ChatMessage(int i, string s, string m)
        {
            this.id = i;
            this.sender = s;
            this.message = m;
            this.next = null;
        }

        public int GetID ()
        {
            return this.id;
        }

        public string GetSender ()
        {
            return this.sender;
        }

        public string GetMessage ()
        {
            return this.message;
        }
    }
}
