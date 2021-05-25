using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class ConcertStream2 : Component
    {
        private readonly Component _component;

        public ConcertStream2(Component component)
        {
            _component = component;
        }

        public void Write(string data)
        {
            Console.WriteLine("concert Class 2 operation store" + data);
            _component.Write("*****######");
        }
    }
}
