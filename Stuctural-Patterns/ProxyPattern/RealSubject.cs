using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public class RealSubject : Subject
    {
        public void Request()
        {
            Console.WriteLine("Real subject object is loading");
        }
    }
}
