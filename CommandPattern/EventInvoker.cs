using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class EventInvoker
    {
        private ICommand _command;

        public EventInvoker(ICommand command)
        {
            _command = command;
        }

        public void SendEvent()
        {
            Console.WriteLine("Event Send");
            _command.Execut();
        }
    }
}
