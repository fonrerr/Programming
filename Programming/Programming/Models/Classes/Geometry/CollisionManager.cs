namespace Programming.Models.Classes.Geometry
{
    public static class CollisionManager
    {
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            double halfWidth1 = rectangle1.Width / 2;
            double halfHeight1 = rectangle1.Lenght / 2;
            double halfWidth2 = rectangle2.Width / 2;
            double halfHeight2 = rectangle2.Lenght / 2;

            double centerX1 = rectangle1.Center.X + halfWidth1;
            double centerY1 = rectangle1.Center.Y + halfHeight1;
            double centerX2 = rectangle2.Center.X + halfWidth2;
            double centerY2 = rectangle2.Center.Y + halfHeight2;

            double deltaX = Math.Abs(centerX1 - centerX2);
            double deltaY = Math.Abs(centerY1 - centerY2);

            double intersectX = halfWidth1 + halfWidth2;
            double intersectY = halfHeight1 + halfHeight2;

            return deltaX < intersectX && deltaY < intersectY;
        }

        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            var radius1 = ring1.OuterRadius;
            var radius2 = ring2.OuterRadius;

            var dX = Math.Abs(ring1.Center.X - ring2.Center.X);
            var dY = Math.Abs(ring1.Center.Y - ring2.Center.Y);

            var c = Math.Sqrt(Math.Pow(dX, 2) + Math.Pow(dY, 2));

            return c < radius1 + radius2;
        }
    }
}
