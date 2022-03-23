using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.Net.Sockets;
using System.IO.Ports;
using System.Windows.Threading;
using System.IO;
using System.Text.RegularExpressions;
using privateMessenger.classes;

namespace privateMessenger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SerialPort mySerialPort;
        public string holdChat, holdPrivate, s, msg;

        public MainWindow()
        {
            InitializeComponent();
            TabControl.SelectionChanged += TabControl_SelectionChanged;
            connectCom();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            switch (TabControl.SelectedIndex)
            {
                case 0:
                    clsClear clearBroadcast = new clsClear(holdChat, msgBox, messageBox);
                    break;
                case 1:
                    clsClear clearCommunication = new clsClear(holdPrivate, msgBox, IdBox, messageBox);
                    break;
            }
        }

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

        private void sendButton_Click(object sender, RoutedEventArgs e)
        {
            if (messageBox.Text != string.Empty)
            {
                switch(TabControl.SelectedIndex)
                {
                    case 0:
                        clsBoodschap communiseer = new clsBoodschap();

                        s = DateTime.Now.ToString("HH:mm");
                        msg = string.Format("@b time: {0} msg: {1}", s, messageBox.Text);
                        mySerialPort.Write(msg);
                        updateText(msg, false);
                        messageBox.Text = string.Empty;
                        break;
                    case 1:
                        string to = IdBox.Text;
                        if (to != "")
                        {
                            for (int i = to.Length; i <= 10; i++)
                            {
                                if (to.Length == 10)
                                {
                                    s = DateTime.Now.ToString("HH:mm:ss");
                                    msg = string.Format("@d to: {2} time: {0} msg: {1}", s, messageBox.Text, to);
                                    mySerialPort.Write(msg);
                                    messageBox.Text = "";
                                }
                                else
                                {
                                    to += " ";
                                }
                            }
                        }
                        else
                        {
                            msgBox.Text = "Fout: vul een ID in.";
                        }
                    break;
                }
            }
            else
            {
                msgBox.Text = "Fout: voer iets in";
            }
        }

        private void onDataRecieved(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            System.Threading.Thread.Sleep(50);
            var buffer = new byte[mySerialPort.BytesToRead];
            mySerialPort.Read(buffer, 0, buffer.Length);
            string str = System.Text.Encoding.ASCII.GetString(buffer);
            Dispatcher.Invoke(() =>
                {
                updateText(str, true);
                });
        }

        private void updateText(string str, bool sent)
        {
            if (!sent)
            {
                if (TabControl.SelectedIndex == 0)
                {
                    string time = str.Substring(str.IndexOf("time: ") + 6, 8);
                    string message = str.Substring(str.IndexOf("msg: ") + 5);
                    holdChat = holdChat + string.Format("{1}\nYou: {0}\n", message, time);
                    msgBox.Text = holdChat;
                    ScrollViewer.ScrollToEnd();
                }
                else if(TabControl.SelectedIndex == 1)
                {
                    string time = str.Substring(str.IndexOf("time: ") + 6, 8);
                    string message = str.Substring(str.IndexOf("msg: ") + 5);
                    string to = str.Substring(str.IndexOf("to: ") + 4, 10);
                    holdPrivate = holdPrivate + string.Format("{1}\nTo: {2} You: {0}\n", message, time, to);
                    msgBox.Text = holdPrivate;
                    ScrollViewer.ScrollToEnd();
                }
            }
            else
            {
                if (str.Contains("@b") != false)
                {
                    string time = str.Substring(str.IndexOf("time: ") + 6, 8);
                    string identifier = str.Substring(str.IndexOf("from ") + 5, 10);
                    string message = str.Substring(str.IndexOf("msg: ") + 5);
                    holdChat = holdChat + string.Format("{2}\n{0}: {1}", identifier, message, time);
                    if (TabControl.SelectedIndex == 0)
                    {
                    msgBox.Text = holdChat;
                    ScrollViewer.ScrollToEnd();
                    }
                }
                else if(str.Contains("@d") != false && str.Contains("@b") == false)
                {
                    string time = str.Substring(str.IndexOf("time: ") + 10, 8);
                    string identifier = str.Substring(str.IndexOf("from ") + 5, 10);
                    string message = str.Substring(str.IndexOf("msg:") + 5);
                    holdPrivate = holdPrivate + string.Format("{2}\n{0}: {1}", identifier, message, time);
                    if (TabControl.SelectedIndex == 1)
                    {
                        msgBox.Text = holdPrivate;
                        ScrollViewer.ScrollToEnd();
                    }
                }
            }
        }


        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch(TabControl.SelectedIndex)
            {
                case 0:
                    msgBox.Text = holdChat;
                    break;
                case 1:
                    msgBox.Text = holdPrivate;
                    break;
            }
        }

        private void Coms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            mySerialPort.Close();
            holdChat = "";
            holdPrivate = "";
            int com = Coms.SelectedIndex;
            if (com == 0)
            {
                string msg = "Selecteer een poort.";
                holdChat = msg;
                holdPrivate = msg;
                msgBox.Text = msg;
            }
            else
            {
                mySerialPort = new SerialPort(string.Format("COM{0}", com), 115200);

                try
                {
                    mySerialPort.Open();
                }
                catch (IOException)
                {
                    sendButton.IsEnabled = false;
                    messageBox.IsEnabled = false;
                    string msg = "Deze poort is niet verbonden.\nControleer of u de module hebt aangesloten.";
                    holdChat = msg;
                    holdPrivate = msg;
                    msgBox.Text = msg;
                    return;
                }
                catch (UnauthorizedAccessException)
                {
                    sendButton.IsEnabled = false;
                    messageBox.IsEnabled = false;
                    string msg = "Deze poort is al in gebruik.\nZorg ervoor dat geen andere programma's deze poort gebruiken en dat dit de juiste poort is.";
                    holdChat = msg;
                    holdPrivate = msg;
                    msgBox.Text = msg;
                    return;
                }

                mySerialPort.ReadTimeout = 100;
                mySerialPort.WriteTimeout = 100;
                mySerialPort.DataReceived += onDataRecieved;
                sendButton.IsEnabled = true;
                messageBox.IsEnabled = true;

                switch (TabControl.SelectedIndex)
                {
                    case 0:
                        msgBox.Text = holdChat;
                        sendButton.IsEnabled = false;
                        break;
                    case 1:
                        msgBox.Text = holdPrivate;
                        sendButton.IsEnabled = true;
                        break;
                }
            }
        }

        private void NumberValidationIdBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("^[0-9]+");
            e.Handled = !regex.IsMatch(e.Text);
        }
    }
}
