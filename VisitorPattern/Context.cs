using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public class Context
    {
        List<Element> _elements = new List<Element>();

        public void Add(Element element)
        {
            _elements.Add(element);
        }

        public void GetVisitors(Visitor visitor)
        {
            if (_elements.Count < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            foreach (var element in _elements)
            {
                element.Accept(visitor);
            }
        }

    }
}
