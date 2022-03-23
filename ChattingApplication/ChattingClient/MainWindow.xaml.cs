using ChattingInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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

namespace ChattingClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static IChattingService Server;
        private static DuplexChannelFactory<IChattingService> _channelFactory;

        public MainWindow()
        {
            InitializeComponent();
            _channelFactory = new DuplexChannelFactory<IChattingService>(new ClientCallBack(), "ChattingServiceEndPoint");
            Server = _channelFactory.CreateChannel();

            SendButton.IsEnabled = false;
        }

        public void TakeMessage(string message, string userName)
        {
            TextDisplayTextBox.Text = userName + " (" + DateTime.Now + "): \r\n" + message + "\r\n \r\n" + TextDisplayTextBox.Text;
            TextDisplayTextBox.ScrollToHome();
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageTextBox.Text.Length == 0)
            {
                return;
            }

            Server.SendMessageToAll(MessageTextBox.Text, UserNameTextBox.Text);
            TakeMessage(MessageTextBox.Text, UserNameTextBox.Text);
            MessageTextBox.Text = "";
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            int returnValue = Server.Login(UserNameTextBox.Text);

            if(returnValue == 1)
            {
                MessageBox.Show("You are already logged in");
            }
            else if(returnValue == 0)
            {
                WelcomeLabel.Content = "Welkom " + UserNameTextBox.Text;
                UserNameTextBox.IsEnabled = false;
                LoginButton.IsEnabled = false;
                SendButton.IsEnabled = true;

                // load messages
                LoadMessages(10);

                // load our users
                LoadUserList(Server.GetCurrentUsers());
            }
        }

        private void LoadMessages(int aantalMessages)
        {

            LoadMessageList(Server.GetMessages(aantalMessages));
        }

        private void LoadMessageList(List<string> list)
        {
            foreach (var message in list)
            {
                AddMessageToList(message);
            }
        }

        private void AddMessageToList(string message)
        {
            TextDisplayTextBox.Text += message + Environment.NewLine;
            TextDisplayTextBox.ScrollToHome();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Server.Logout();
        }

        public void AddUserToList(string userName)
        {
            if (UsersListBox.Items.Contains(userName))
            {
                return;
            }
            UsersListBox.Items.Add(userName);
        }

        public void RemoveUserFromList(string userName)
        {
            if(UsersListBox.Items.Contains(userName))
            {
                return;
            }
            UsersListBox.Items.Remove(userName);
        }

        private void LoadUserList(List<string> users)
        {
            foreach(var user in users)
            {
                AddUserToList(user);
            }
        }
    }
}
