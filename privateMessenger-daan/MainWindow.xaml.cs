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
using privateMessenger.Classes;

namespace privateMessenger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SerialPort mySerialPort;
        string holdChat, holdPrivate, s, msg;

        public MainWindow()
        {
            InitializeComponent();

            openIntroPagina();

            TabControl.SelectionChanged += TabControl_SelectionChanged;
            connectCom();
        }

        public MainWindow(bool doNotMakeInvisible)
        {
            InitializeComponent();
            TabControl.SelectionChanged += TabControl_SelectionChanged;
            connectCom();
        }

        private void openIntroPagina ()
        {
            this.Visibility = Visibility.Hidden;

            Hide();
            introPagina form = new introPagina();
            form.ShowDialog();
            Close();
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
                        string msg = "Can't find working port.\nPlease check if you plugged in the module.";
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
                    string msg = "This port is already in use.\nPlease make sure no other programs are using this port\naswell as that it is the correct port.";
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
                        s = DateTime.Now.ToString("HH:mm");
                        msg = string.Format("@b time: {0} msg: {1}", s, messageBox.Text);
                        mySerialPort.Write(msg);
                        updateText(msg, false);
                        messageBox.Text = string.Empty;
                        break;
                    case 1:
                        string to = IdBox.Text;
                        if (to != string.Empty)
                        {
                            for (int i = to.Length; i <= 10; i++)
                            {
                                if (to.Length == 10)
                                {
                                    s = DateTime.Now.ToString("HH:mm");
                                    msg = string.Format("@d to: {2} time: {0} msg: {1}", s, messageBox.Text, to);
                                    mySerialPort.Write(msg);
                                    updateText(msg, false);
                                    messageBox.Text = string.Empty;
                                }
                                else
                                {
                                    to += " ";
                                }
                            }
                        }
                        else
                        {
                            msgBox.Text = "Error: Please fill in an ID.";
                        }
                    break;
                }
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

        private void SosButton_Click(object sender, RoutedEventArgs e)
        {
            Messages sos = new Messages();
            sos.Message = "SOS";

            try
            {
                s = DateTime.Now.ToString("HH:mm");
                msg = string.Format("@b time: {0} msg: {1}", s, sos.Message);
                mySerialPort.Write(msg);
                updateText(msg, false);
                messageBox.Text = string.Empty;
            }
            catch
            {
                msgBox.Text = msgBox.Text + "\nPlease Make sure you're connected!";
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
                    sendButton.IsEnabled = true;
                    break;
            }
        }

        private void Coms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            mySerialPort.Close();
            holdChat = string.Empty;
            holdPrivate = string.Empty;
            int com = Coms.SelectedIndex;
            if (com == 0)
            {
                string msg = "Please select a port.\nYou can do this in the top right.";
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
                    string msg = "This port isn't connected.\nPlease check if you plugged in the module.";
                    holdChat = msg;
                    holdPrivate = msg;
                    msgBox.Text = msg;
                    return;
                }
                catch (UnauthorizedAccessException)
                {
                    sendButton.IsEnabled = false;
                    messageBox.IsEnabled = false;
                    string msg = "This port is already in use.\nPlease make sure no other programs are using this port\naswell as that it is the correct port.";
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
                switch(TabControl.SelectedIndex)
                {
                    case 0:
                        msgBox.Text = holdChat;
                        break;
                    case 1:
                        msgBox.Text = holdPrivate;
                        msgBox.IsEnabled = true;
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
