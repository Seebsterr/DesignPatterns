using System;

namespace DesignPatterns.Factories.InnerFactory
{
    public class Point
    {
        private double _x, _y;

        private Point(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public static Point Origin = new Point(0, 0);

        public static class Factory
        {
            public static Point NewCatresianPoint(double x, double y)
            {
                return new Point(x, y);
            }

            public static Point NewPolarPoint(double rho, double theta)
            {
                return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
            }
        }

        public override string ToString()
        {
            return $"x={_x}, y={_y}";
        }
    }
}