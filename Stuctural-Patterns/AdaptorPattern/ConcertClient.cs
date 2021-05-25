using System;
using System.Collections.Generic;
using System.Text;

namespace AdaptorPattern
{
    public class ConcertClient : Client
    {
        public void ClientMethod()
        {
            Console.WriteLine("override Client Method from Concert Client");
        }
    }
}
