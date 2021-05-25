using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern
{
    public class PointService
    {
        public List<Point> GetPoints()
        {
            var point = new Point(20, 50, (new FlyweightFactory()).GetPointType(PointType.CAFA));
            var points = new List<Point>();
            points.Add(point);
            return points;
        }
    }
}
