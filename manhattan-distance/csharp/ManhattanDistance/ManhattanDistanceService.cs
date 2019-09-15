using System;

namespace ManhattanDistance
{
    public class ManhattanDistanceService
    {
        public int ManhattanDistance(Point p1, Point p2)
        {
            return p1.DistanceTo(p2);
        }
    }
}
