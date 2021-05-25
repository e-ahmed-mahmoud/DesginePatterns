using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********** Strategy Pattern ******* ");
            var image = new Context_ImageStore();

            image.StoreImage( new JpegCompress(), new BlackAndWaitFilter());
        }
    }
}
