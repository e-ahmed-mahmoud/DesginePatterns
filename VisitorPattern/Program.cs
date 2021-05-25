using System;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********* Visitor Pattern ********** ");

            var context = new Context();
            context.Add(new ElementNode1());
            context.Add(new ElementNode2());

            context.GetVisitors(new ConcertVisitor());
            context.GetVisitors(new ConcertVisitor2());
        }
    }
}
