using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public class Compress : Handler
    {

        public Compress(Handler next):base(next)
        {
        }

        protected override bool DoHandler(HttpRequest httpRequest)
        {
            Console.WriteLine("Compressed");
            return false ;
        }
    }
}
