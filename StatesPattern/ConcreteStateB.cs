using System;
using System.Collections.Generic;
using System.Text;

namespace StatesPattern
{
    public class ConcreteStateB : IState
    {
        public void MouseDown()
        {
            Console.WriteLine("Stat B Mouse Down");
        }

        public void MouseUp()
        {
            Console.WriteLine("Stat B Mouse Up");
        }
    }
}
