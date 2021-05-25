using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public class Authentication : Handler
    {

        public Authentication(Handler next) : base (next)
        {
        }

        protected override bool DoHandler(HttpRequest httpRequest)
        {
            if (httpRequest.UserName == "admin" && httpRequest.Pass =="123")
            {
                Console.WriteLine("Authenticated");                
                return false;
            }
            else
            {
                Console.WriteLine(" Not Authenticated");                
                return true;
            }

        }
    }
}
