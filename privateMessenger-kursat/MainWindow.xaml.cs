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

namespace privateMessenger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, string> gebruikers = new Dictionary<string, string>();
        Beheerder Selectedbeheerder = new Beheerder();
        Gebruiker Selectedgebruiker = new Gebruiker();
        Post Selectedposts = new Post();
        Gebruiker gebruiker = new Gebruiker();
        Beheerder beheerder = new Beheerder();
        db db = new db();
        SerialPort mySerialPort;
        string holdChat, holdPrivate, time, msg;
        List<string> gebruikerid = new List<string>();
        List<string> gebruikertekst = new List<string>();
        

        public MainWindow()
        {
            InitializeComponent();
            TabControl.SelectionChanged += TabControl_SelectionChanged;
            connectCom();
            loadBeheerder();
            loadGebruiker();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            switch (TabControl.SelectedIndex)
            {
                case 0:
                    holdChat = "";
                    //msgBox.Text = "";
                    messageBox.Text = "";
                    break;
                case 1:
                    holdPrivate = "";
                    //msgBox.Text = "";
                    IdBox.Text = "";
                    messageBox.Text = "";
                    break;
            }
        }

        public void loadGebruiker()
        {
            List<Gebruiker> gebruikers = db.GetGebruikers();

            foreach (Gebruiker gebruiker in gebruikers)
            {
                GebruikerCombo.Items.Add(gebruiker);
            }
        }

        public void loadBeheerder()
        {
            List<Beheerder> beheerder = db.GetBeheerder();

            foreach (Beheerder beheerders1 in beheerder)
            {
                BeheerderCombo.Items.Add(beheerders1.Naam).ToString();
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
                        string msg = "Can't find working port.\nPlease check if you plugged in the module.";
                        holdChat = msg;
                        holdPrivate = msg;
                        //msgBox.Text = msg;
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
                    //msgBox.Text = msg;
                    Coms.SelectedIndex = i;
                    break;
                }
                Coms.SelectedIndex = i;
                break;
            }
        }
        string identifier = str.Substring(str.IndexOf("from ") + 5, 10);


        private void sendButton_Click(object sender, RoutedEventArgs e)
        {
            Gebruiker gebruikers = new Gebruiker();
            
            int beheerderid = Selectedbeheerder.Beheerderid;

            string message = messageBox.Text;
            if (message != "")
            {
                switch (TabControl.SelectedIndex)
                {
                    case 0:

                            DateTime tijd = DateTime.Now;
                            
                            time = DateTime.Now.ToString("HH:mm:ss");
                            msg = string.Format("@b time: {0} msg: {1}", tijd, message);
                            mySerialPort.Write(msg);
                            updateText(msg, false);
                            Beheerder beheerder = new Beheerder(beheerderid);
                            Chat chat = new Chat();
                           // chat.getBeheerderid(beheerder);
                           // db.AddPostBeheerder(beheerder);
                            listBoxPosts.Items.Clear();
                            listBoxPosts.Items.Add(msg);
                        
                        break;
                    case 1:
                        string to = IdBox.Text;
                        if (to != "")
                        {
                            for (int i = to.Length; i <= 10; i++)
                            {
                                if (to.Length == 10)
                                {
                                    time = DateTime.Now.ToString("HH:mm:ss");
                                    msg = string.Format("@d to: {2} time: {0} msg: {1}", time, messageBox.Text, to);
                                    mySerialPort.Write(msg);
                                    updateText(msg, false);
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
                            //msgBox.Text = "Error: Please fill in an ID.";
                        }
                        break;
                }
            }
        }

        public void Responce()
        {
        }
        //private void GebruikerReceive(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        //{
        //    System.Threading.Thread.Sleep(50);
        //    var buffer = new byte[mySerialPort.BytesToRead];
        //    mySerialPort.Read(buffer, 0, buffer.Length);
        //    string str = System.Text.Encoding.ASCII.GetString(buffer);
        //     string identifier = str.Substring(str.IndexOf("from ") + 5, 10);

            
        //    Gebruiker gebruiker = new Gebruiker(identifier);
        //    db.AddGebruiker(gebruiker);
         
        //    gebruikerid.Add(identifier);


        //    //Dispatcher.Invoke(() =>
        //    //{
        //    //    updateText(str, true);
        //    //});
        //}

        private void onDataRecieved(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            System.Threading.Thread.Sleep(50);
            var buffer = new byte[mySerialPort.BytesToRead];
            mySerialPort.Read(buffer, 0, buffer.Length);
            string str = System.Text.Encoding.ASCII.GetString(buffer);
            string identifier = str.Substring(str.IndexOf("from ") + 5, 10);

            string message = str.Substring(str.IndexOf("msg: ") + 5);
            
            //db.AddPostGebruiker(gebruiker);
            gebruikerid.Add(identifier);
            gebruikertekst.Add(message);
            //Chat chat = new Chat(identifier);
            

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
                    listBoxPosts.Items.Clear();
                    string time = str.Substring(str.IndexOf("time: ") + 6, 8);
                    string message = str.Substring(str.IndexOf("msg: ") + 5);
                    holdChat = holdChat + string.Format("{1}\nYou: {0}\n", message, time);

                    listBoxPosts.Items.Add(holdChat);
                    
                    //msgBox.Text = holdChat;
                    ScrollViewer.ScrollToEnd();
                }
                else if (TabControl.SelectedIndex == 1)
                {
                    listBoxPosts.Items.Clear();
                    string time = str.Substring(str.IndexOf("time: ") + 6, 8);
                    string message = str.Substring(str.IndexOf("msg: ") + 5);
                    string to = str.Substring(str.IndexOf("to: ") + 4, 10);
                    holdPrivate = holdPrivate + string.Format("{1}\nTo: {2} You: {0}\n", message, time, to);
                    listBoxPosts.Items.Add(holdPrivate);
                    //msgBox.Text = holdPrivate;
                    ScrollViewer.ScrollToEnd();
                }
            }
            else
            {
                if (str.Contains("@b") != false)
                {
                    listBoxPosts.Items.Clear();
                    string time = str.Substring(str.IndexOf("time: ") + 6, 8);
                    string identifier = str.Substring(str.IndexOf("from ") + 5, 10);
                    string message = str.Substring(str.IndexOf("msg: ") + 5);
                    Chat chat = new Chat();
                    holdChat = holdChat + string.Format("{2}\n{0}: {1}", identifier, message, time);
                    Gebruiker gebruiker = new Gebruiker(identifier);
                    listBoxPosts.Items.Add(identifier);
                  //  gebruikerid.Add(identifier);
                    if (TabControl.SelectedIndex == 0)
                    {
                        
                        listBoxPosts.Items.Add(holdChat);
                        //listBoxPosts.Items.Add(Selectedbeheerder.ToString());
                        ScrollViewer.ScrollToEnd();
                    }
                }
                else if (str.Contains("@d") != false && str.Contains("@b") == false)
                {
                    listBoxPosts.Items.Clear();
                    string time = str.Substring(str.IndexOf("time: ") + 10, 8);
                    string identifier = str.Substring(str.IndexOf("from ") + 5, 10);
                    string message = str.Substring(str.IndexOf("msg:") + 5);
                    holdPrivate = holdPrivate + string.Format("{2}\n{0}: {1}", identifier, message, time);
                    if (TabControl.SelectedIndex == 1)
                    {

                        listBoxPosts.Items.Add(holdPrivate);
                        ScrollViewer.ScrollToEnd();
                    }
                }
            }
        }

        private void BeheerderCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            List<Beheerder> beheerders = db.GetBeheerder();

            foreach (Beheerder beheerder in beheerders)
            {
                if (BeheerderCombo.SelectedItem.ToString() == beheerder.Naam.ToString())
                {
                    Selectedbeheerder = beheerder;

                    break;
                }
            }
        }

        private void GebruikerCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<Gebruiker> gebruikers = db.GetGebruikers();

            foreach (Gebruiker gebruiker in gebruikers)
             {
                if (GebruikerCombo.SelectedItem.ToString() == gebruiker.Gebruikerid.ToString())
                {
                    Selectedgebruiker = gebruiker;
                    break;
                }
            }
        }



        private void listBoxPosts_DoubleClick(object sender, MouseButtonEventArgs e)
        {
             
            //if (chat.Actief == false)
            //{
               
            //    chat.Actief = true;
            //    MessageBox.Show("Uw gesprek is Active");
            //    messageBox.IsEnabled = true;

            //}
            //else 
            //{
            //    chat.Actief = false;
            //    MessageBox.Show("Uw gesprek is InActive");
            //    messageBox.IsEnabled = false;
            //}
            
           

            //string ggebruikerid = gebruikerid.ToString();
            //string ggebruikertekst = gebruikertekst.ToString();

            //List<Post> posts = db.GetPosts();

            //foreach (Post berichten in posts)
            //{

            //    if (listBoxPosts.SelectedIndex.ToString() == ggebruikerid.ToString())
            //    {
            //        if (listBoxPosts.SelectedIndex.ToString() == ggebruikertekst.ToString())
            //        {
            //            MessageBox.Show(String.Format("ID = {0}, Tekst = {1}", ggebruikerid, ggebruikertekst));
            //            //Selectedposts = berichten;
            //        }
            //        break;
            //    }
            //}
            
            
        }

        private void GebruikerBtn_Click(object sender, RoutedEventArgs e)
        {
            GebruikerForm gebruikerForm = new GebruikerForm();
            gebruikerForm.Show();
        }

        private void makeChatBtn_Click(object sender, RoutedEventArgs e)
        {
            int beheerid = Selectedbeheerder.Beheerderid;
            string gebruikerid = Selectedgebruiker.Gebruikerid;
            var date = DateTime.Now.ToString ("yyyy-MM-dd HH:mm:ss");
          

            Chat chat = new Chat(beheerid, gebruikerid, date);

            //db.AddChat(chat);
            ChatListBox.Items.Add(chat);

        }

        private void ChatListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
                switch (TabControl.SelectedIndex)
                {
                    case 0:
                        //msgBox.Text = holdChat;
                        break;
                    case 1:
                        //msgBox.Text = holdPrivate;
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
                    string msg = "Please select a port.\nYou can do this in the top right.";
                    holdChat = msg;
                    holdPrivate = msg;
                    //msgBox.Text = msg;
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
                        //msgBox.Text = msg;
                        return;
                    }
                    catch (UnauthorizedAccessException)
                    {
                        sendButton.IsEnabled = false;
                        messageBox.IsEnabled = false;
                        string msg = "This port is already in use.\nPlease make sure no other programs are using this port\naswell as that it is the correct port.";
                        holdChat = msg;
                        holdPrivate = msg;
                        //msgBox.Text = msg;
                        return;
                    }
                    mySerialPort.ReadTimeout = 100;
                    mySerialPort.WriteTimeout = 100;
                    mySerialPort.DataReceived += onDataRecieved;
                 //   mySerialPort.DataReceived += GebruikerReceive;
                    sendButton.IsEnabled = true;
                    messageBox.IsEnabled = true;
                    switch (TabControl.SelectedIndex)
                    {
                        case 0:
                            ////msgBox.Text = holdChat;
                            break;
                        case 1:
                            //msgBox.Text = holdPrivate;
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

