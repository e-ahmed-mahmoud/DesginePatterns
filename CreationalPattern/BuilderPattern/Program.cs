using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************ Builder Pattern **************");
            var director = new Director(new ConcertBuilder1());
            director.GetFullProduct();
            Console.WriteLine("\n");

            var product = new ConcertBuilder2();
            product.BuildStepA();
            product.BuildStepB();
            product.GetProduct().BuildProduct();
        }
    }
}
