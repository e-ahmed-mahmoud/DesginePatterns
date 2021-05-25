using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern
{
    public enum PointType
    {
        CAFA,
        HOSPITAL,
        HOME
    }
    public class Point
    {
        public int X { get; }
        public int Y { get; }

        private readonly Flyweight flyweight;

        public Point(int x, int y,Flyweight flyweight)
        {
            this.flyweight = flyweight;
            X = x;
            Y = y;
        }

        public void Draw()
        {
            Console.WriteLine($" point is : ( {X} , {Y} ) , type is : {flyweight.pointType} ");
        }

    }
}
