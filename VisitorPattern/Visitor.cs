using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public interface Visitor
    {
        void Apply(ElementNode1 elementNode1);
        void Apply(ElementNode2 elementNode2);

        //add new apply for any new node.

    }
}
