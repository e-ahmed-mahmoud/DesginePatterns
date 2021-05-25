using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern
{
    public class Memento
    {
        
        public Memento(Original original)
        {
            this.Content = original.Content;
            this.FontName = original.FontName;
            this.FontSize = original.FontSize;
        }

        public string Content { get; set; }
        public string FontName { get; set; }
        public int FontSize { get; set; }

    }
}
