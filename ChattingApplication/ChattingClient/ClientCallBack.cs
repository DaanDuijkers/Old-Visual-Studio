using ChattingInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ChattingClient
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
    
    public class ClientCallBack : IClient
    {
        public void GetMessage(string Message, string userName)
        {
            ((MainWindow)Application.Current.MainWindow).TakeMessage(Message, userName);
        }

        public void GetUpdate(int value, string userName)
        {
            switch (value)
            {
                case 0:
                    {
                        ((MainWindow)Application.Current.MainWindow).AddUserToList(userName);
                        break;
                    }
                case 1:
                    {
                        ((MainWindow)Application.Current.MainWindow).RemoveUserFromList(userName);
                        break;
                    }
            }
        }
    }
}
