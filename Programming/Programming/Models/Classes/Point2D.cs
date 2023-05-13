﻿namespace Programming.Models.Classes
{
    public class Point2D
    {
        private double _x;
        private double _y;

        public double X
        {
            get { return _x; }
            private set
            {
                Validator.AssertOnPositiveValue(value, nameof(X));
                _x = value;
            }
        }

        public double Y
        {
            get { return _y; }
            private set
            {
                Validator.AssertOnPositiveValue(value, nameof(Y));
                _y = value;
            }
        }

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static double Distance(Point2D p1, Point2D p2)
        {
            double dx = p1.X - p2.X;
            double dy = p1.Y - p2.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
