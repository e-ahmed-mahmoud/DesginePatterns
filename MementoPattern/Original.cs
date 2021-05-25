using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern
{
    public class Original
    {
        public string Content {get; set;}
        public string FontName { get; set; }
        public int  FontSize { get; set; }

        public Memento CreateMemento()
        {
            return new Memento(new Original() { Content=this.Content, FontName=this.FontName, FontSize=this.FontSize });
        }

        public void Restore (Memento memento)
        {
            this.Content = memento.Content;
            this.FontName = memento.FontName;
            this.FontSize = memento.FontSize;
        }
    }
}
