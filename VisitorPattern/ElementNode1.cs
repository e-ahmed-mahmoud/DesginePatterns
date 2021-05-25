using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public class ElementNode1 : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.Apply(this);
        }
    }
}
