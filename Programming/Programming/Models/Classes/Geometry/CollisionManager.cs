﻿namespace Programming.Models.Classes.Geometry
{
    public static class CollisionManager
    {
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {

            //double diffx = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            //double diffy = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);


            //bool res =  (diffx < (rectangle1.Width + rectangle2.Width) / 2) && (diffy < (rectangle1.Lenght + rectangle2.Lenght) / 2);
            //return res;

            return Math.Abs(rectangle1.Center.X - rectangle2.Center.X) < rectangle1.Lenght / 2 + rectangle2.Lenght / 2
                && Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y) < rectangle1.Width / 2 + rectangle2.Width / 2;
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
