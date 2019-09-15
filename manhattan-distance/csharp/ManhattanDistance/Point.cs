using System;
using System.Collections.Generic;

namespace ManhattanDistance
{
    public class Point
    {
        private int _x;
        private int _y;

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int DistanceTo(Point otherPoint)
        {
            return otherPoint.VerticalDistanceTo(_y) + otherPoint.HorizontalDistanceTo(_x);
        }

        public int VerticalDistanceTo(int y)
        {
            return Math.Abs(_y - y);
        }

        public int HorizontalDistanceTo(int x)
        {
            return Math.Abs(_x - x);
        }

        public override bool Equals(object obj)
        {
            if (object.ReferenceEquals(null, obj))
                return false;

            if (object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != GetType())
                return false;

            return IsEqual((Point) obj);
        }

        public bool IsEqual(Point otherPoint)
        {
            var verticalDistance = otherPoint.VerticalDistanceTo(_y);
            var horizontalDistance = otherPoint.HorizontalDistanceTo(_x);

            if (verticalDistance == 0 && horizontalDistance == 0)
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(Point left, Point right)
        {
            return EqualityComparer<Point>.Default.Equals(left, right);
        }

        public static bool operator !=(Point left, Point right)
        {
            return !(left == right);
        }
    }
}
