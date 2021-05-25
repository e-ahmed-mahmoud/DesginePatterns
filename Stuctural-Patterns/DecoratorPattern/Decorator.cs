using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Decorator : Component
    {
        private readonly Component _component;

        public Decorator(Component component)
        {
            _component = component;
        }

        public void Write(string data)
        {

            Console.WriteLine("Decorator class store" + data);
            _component.Write(data);
        }
    }
}
