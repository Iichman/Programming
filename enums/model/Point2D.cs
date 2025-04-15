using System;

namespace Programming.Model
{
    public class Point2D
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X:F2}; {Y:F2})";
        }
    }
}