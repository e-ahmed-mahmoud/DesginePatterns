using System;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************ Flyweight Pattern ************* ");
            var point = new Point(50, 20, new FlyweightFactory().GetPointType(PointType.CAFA));
            point.Draw();
        }
    }
}
