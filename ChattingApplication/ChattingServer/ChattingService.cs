using ChattingInterfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ChattingServer
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = 
        InstanceContextMode.Single)]

    public class ChattingService : IChattingService
    {
        public ConcurrentDictionary<string, ConnectedClient> _connectedClients = 
            new ConcurrentDictionary<string, ConnectedClient>();

        public int Login(string userName)
        {
            // is anyone else logged in with my name
            foreach(var client in _connectedClients)
            {
                if(client.Key.ToLower() == userName.ToLower())
                {
                    //if yes
                    return 1;
                }
            }

            var establishedUserConnection = OperationContext.Current.GetCallbackChannel<IClient>();

            ConnectedClient newClient = new ConnectedClient();
            newClient.connection = establishedUserConnection;
            newClient.UserName = userName;

            _connectedClients.TryAdd(userName, newClient);

            updateHelper(0, userName);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Client login: {0} at {1}", newClient.UserName, System.DateTime.Now);
            Console.ResetColor();

            return 0;
        }

        public void Logout()
        {
            ConnectedClient client = GetMyClient();
            if(client != null)
            {
                ConnectedClient removedClient;
                _connectedClients.TryRemove(client.UserName, out removedClient);

                updateHelper(1, removedClient.UserName);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Client logoff: {0} at {1}", removedClient.UserName, System.DateTime.Now);
                Console.ResetColor();
            }
        }

        public ConnectedClient GetMyClient()
        {
            var establishedUserConnection = OperationContext.Current.GetCallbackChannel<IClient>();
            foreach(var client in _connectedClients)
            {
                if(client.Value.connection == establishedUserConnection)
                {
                    return client.Value;
                }
            }
            return null;
        }

        private SqlConnection con = Database.Connect();
        private SqlCommand cmd = Database.Command();
        private SqlDataAdapter adapt = Database.DataAdapter();
        private SqlCommand userID = Database.Command();

        public void opslaanMessage(string username, string message)
        {
            cmd = new SqlCommand(
                "INSERT INTO Message(Gebruiker,Message) VALUES(@Gebruiker,@Message)",
                con);

            con.Open();
                cmd.Parameters.AddWithValue("@Gebruiker", username);
                cmd.Parameters.AddWithValue("@Message", message);
                cmd.ExecuteNonQuery();
            con.Close();


        }

        public void SendMessageToAll(string Message, string userName)
        {
            //message opslaan
            opslaanMessage(userName, Message);

            foreach(var client in _connectedClients)
            {
                if(client.Key.ToLower() != userName.ToLower())
                {
                    client.Value.connection.GetMessage(Message, userName);
                }
            }
        }

        private void updateHelper(int value, string userName)
        {
            foreach (var client in _connectedClients)
            {
                if(client.Value.UserName.ToLower() != userName.ToLower())
                {
                    client.Value.connection.GetUpdate(value, userName);
                }
            }
        }

        public List<string> GetCurrentUsers()
        {
            List<String> listOfUsers = new List<string>();
            foreach(var client in _connectedClients)
            {
                listOfUsers.Add(client.Value.UserName);
            }
            return listOfUsers;
        }

        private SqlCommand SelectMessage = Database.Command();
        private SqlConnection Connection = Database.Connect();

        public List<string> GetMessages(int aantalMessages)
        {
            List<String> listOfMessages = new List<string>();

            SelectMessage = new SqlCommand(
                "SELECT TOP " + aantalMessages + " Gebruiker, Tijd, Message FROM Message ORDER BY ID DESC",
            Connection);
            Connection.Open();
                SqlDataReader reader = SelectMessage.ExecuteReader();
                while (reader.Read())
                {
                    listOfMessages.Add(reader[0].ToString() + " (" + reader[1].ToString() + "): \r\n" +
                        reader[2].ToString() + "\r\n");
                }
            Connection.Close();

            return listOfMessages;
        }
    }
}
