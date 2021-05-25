using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Stream : Component
    {
        public void Write (string data)
        {
            Console.WriteLine("Main stream class store " + data);
        }
    }
}
