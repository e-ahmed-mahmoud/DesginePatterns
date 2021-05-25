using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace FlyweightPattern
{
    public class FlyweightFactory
    {
        private readonly Dictionary<PointType, Flyweight> PointIcons= new Dictionary<PointType, Flyweight>();

        public Flyweight GetPointType(PointType pointType)
        {
            if (! PointIcons.ContainsKey(pointType))
            {
                PointIcons.Add(pointType, new Flyweight(pointType, icon: null));
            }
            return PointIcons.GetValueOrDefault(pointType);
        }
    }
}
