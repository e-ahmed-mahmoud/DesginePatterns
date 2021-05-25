using System;
using System.Collections.Generic;
using System.Text;

namespace CompositPattern
{
    public class Leaf1 : Component
    {
        public void Render()
        {
            Console.WriteLine("Leaf 1 is rendering");
        }
    }
}
