using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class Message
    {
        public string Text { get; }

        public Message(string message)
        {
            Text = message;
        }
    }
}
