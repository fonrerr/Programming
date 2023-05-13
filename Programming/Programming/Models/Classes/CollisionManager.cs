namespace Programming.Models.Classes
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

            double diffX = Math.Abs(centerX1 - centerX2);
            double diffY = Math.Abs(centerY1 - centerY2);

            return (diffX < halfWidth1 + halfWidth2) && (diffY < halfHeight1 + halfHeight2);
        }

        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double distance = Point2D.Distance(ring1.Center, ring2.Center);
            double sumOfRadii = ring1.OuterRadius + ring2.OuterRadius;
            if (distance < Math.Abs(ring1.OuterRadius - ring2.OuterRadius))
            {
                return true;
            }
            else
            {
                return distance < sumOfRadii;
            }
        }
    }
}
