using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }
}
