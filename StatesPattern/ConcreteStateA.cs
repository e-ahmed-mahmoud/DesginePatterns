using System;
using System.Collections.Generic;
using System.Text;

namespace StatesPattern
{
    public class ConcreteStateA : IState
    {
        public void MouseDown()
        {
            Console.WriteLine("State A Mouse Down");
        }

        public void MouseUp()
        {
            Console.WriteLine("State A Mouse UP");
        }
    }
}
