using System;

namespace DesignPatterns.Factories.Factory
{
    public class Point
    {
        private double _x, _y;

        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public override string ToString()
        {
            return $"x={_x}, y={_y}";
        }
    }
}