using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class ConcertStream : Component
    {
        private readonly Component _component;

        public ConcertStream(Component component)
        {
            _component = component;
        }

        public void Write(string data)
        {

            Console.WriteLine("Concert 1 stream class store " + data);
            _component.Write(data.Substring(0,(data.Length -5)));
        }
    }
}
