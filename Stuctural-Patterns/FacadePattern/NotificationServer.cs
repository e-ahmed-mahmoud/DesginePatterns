using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class NotificationServer
    {
        private string _serverIP;

        public NotificationServer(string serverIP)
        {
            _serverIP = serverIP;
        }

        public void Send(Message message , string ip, AuthToken authToken)
        {
            Console.WriteLine("sending message: " + message.Text + " : " + ip);
        }
        public void Disconnect()
        {
            Console.WriteLine("disconnecting Server");
        } 

    }
}
