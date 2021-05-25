using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class ConcertCommand2 : ICommand
    {
        private EventReciver2 _reciver2;

        public ConcertCommand2(EventReciver2 reciver2)
        {
            _reciver2 = reciver2;
        }

        public void Execut()
        {
            _reciver2.EventHandler();
        }
    }
}
