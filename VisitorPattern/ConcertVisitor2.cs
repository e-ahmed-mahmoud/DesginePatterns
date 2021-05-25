using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public class ConcertVisitor2 : Visitor
    {
        public void Apply(ElementNode1 elementNode1)
        {
            Console.WriteLine("Apply operation 2 in Node1 ");
        }

        public void Apply(ElementNode2 elementNode2)
        {
            Console.WriteLine("Apply operation 2 in Node2 ");
        }

    }
}
