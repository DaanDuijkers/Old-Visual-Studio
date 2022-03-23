using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleChatApp
{
    delegate void MessageHandler(Message message);

    class MessageRelayHub
    {
        public event MessageHandler NewMessage;

        public void SendMessage(Message message)
        {
            if (NewMessage != null)
            {
                NewMessage(message);
            }
        }
    }
}