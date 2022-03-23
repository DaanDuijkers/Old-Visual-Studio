using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace privateMessenger.classes
{
    class clsConnect
    {
        private void connectCom()
        {
            for (int i = 0; i <= 20; i++)
            {
                mySerialPort = new SerialPort(string.Format("COM{0}", i), 115200);
                try
                {
                    mySerialPort.Open();
                }
                catch (IOException)
                {
                    if (i < 20)
                    {
                        continue;
                    }
                    else
                    {
                        sendButton.IsEnabled = false;
                        messageBox.IsEnabled = false;
                        Coms.SelectedIndex = 0;
                        string msg = "Kan geen werkende poort vinden.\nControleer of de module is aangesloten.";
                        holdChat = msg;
                        holdPrivate = msg;
                        msgBox.Text = msg;
                        break;
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    sendButton.IsEnabled = false;
                    messageBox.IsEnabled = false;
                    string msg = "Deze poort is al in gebruik.\nZorg ervoor dat geen andere programma's deze poort gebruiken en dat dit de juiste poort is.";
                    holdChat = msg;
                    holdPrivate = msg;
                    msgBox.Text = msg;
                    Coms.SelectedIndex = i;
                    break;
                }
                Coms.SelectedIndex = i;
                break;
            }
        }
    }
}
