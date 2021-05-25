using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern
{

    public class Flyweight
    {
        public PointType pointType{ get; }

        public byte[] Icon { get; }


        public Flyweight(PointType pointType, byte[] icon)
        {
            this.pointType = pointType;
            Icon = icon;
        }
    }
}
