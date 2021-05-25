using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class ConcertCommand : ICommand
    {
        private EventReciver _eventReciver;

        public ConcertCommand(EventReciver eventReciver)
        {
            _eventReciver = eventReciver;
        }

        public void Execut()
        {
            _eventReciver.EventHandler();
        }

    }
}
