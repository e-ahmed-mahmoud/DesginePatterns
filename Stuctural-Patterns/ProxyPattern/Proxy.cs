using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public class Proxy : Subject
    {
        private RealSubject realSubject; 
        public void Request()
        {
            Console.WriteLine("speak to proxy agent");
            if (realSubject == null)
            {
                realSubject = new RealSubject();
            }
            realSubject.Request();
        }
    }
}
