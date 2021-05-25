using System;
using System.Collections.Generic;
using System.Text;

namespace CompositPattern
{
    public class Leaf2 : Component
    {
        public void Render()
        {
            Console.WriteLine("Leaf 2 is rendering");
        }
    }
}
