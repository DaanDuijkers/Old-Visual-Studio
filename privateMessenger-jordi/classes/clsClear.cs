using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace privateMessenger
{
    class clsClear
    {
        public clsClear(string holdChat, TextBlock msgBox, TextBox messageBox)
        {
            holdChat = string.Empty;
            msgBox.Text = string.Empty;
            messageBox.Text = string.Empty;
        }

        public clsClear(string holdPrivate, TextBlock msgBox, TextBox IdBox, TextBox messageBox)
        {
            holdPrivate = string.Empty;
            msgBox.Text = string.Empty;
            IdBox.Text = string.Empty;
            messageBox.Text = string.Empty;
        }
    }
}
