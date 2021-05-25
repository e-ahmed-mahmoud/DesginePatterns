using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************ Decorator Pattern **************");
            PublishData(new ConcertStream2(new ConcertStream( new Stream())));

        }
        public static void PublishData(Component component)
        {
            component.Write("Name : Ali ");
        }
    }
}
