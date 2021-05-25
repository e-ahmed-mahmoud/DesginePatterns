using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class Facade
    {

        public void Send(string msg , string ip)
        {
            Message message = new Message(msg);
            NotificationServer notificationServer = new NotificationServer(ip);
            AuthToken authToken = new AuthToken();
            notificationServer.Send(message, ip, authToken);
            notificationServer.Disconnect();

        }
    }
}
