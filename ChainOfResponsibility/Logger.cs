using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public class Logger : Handler
    {
        public Logger(Handler next) : base (next)
        {

        }

        protected override bool DoHandler(HttpRequest httpRequest)
        {
            Console.WriteLine("logging");

            return false;

        }
    }
}
