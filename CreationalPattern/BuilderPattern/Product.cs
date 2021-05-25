using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Product
    {
        List<object> _parts = new List<object>();

        public void Add(object part)
        {
            _parts.Add(part);
        }

        public void BuildProduct()
        {
            foreach (var item in _parts)
            {
                Console.WriteLine(item);
            }
        }
    }
}
