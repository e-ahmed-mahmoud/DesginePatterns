using System;
using System.Collections.Generic;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********* Iterator Pattern ***********");

            var container = new Container(new List<string> { "Ahmed", "Ali" });

            var it = container.CreateIterator();
            while (it.IsDone())
            {
                Console.WriteLine(it.Current());
                it.Next();
            }
        }
    }
}
