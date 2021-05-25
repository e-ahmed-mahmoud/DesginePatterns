using System;

namespace CompositPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********** Composit Pattern ************");
            var composit = new Composit();
            var composit2 = new Composit();

            composit.Add(new Leaf1());
            composit.Add(new Leaf2());
            
            composit2.Add(new Leaf1());
            composit.Add(composit2);

            composit.Render();
        }
    }
}
