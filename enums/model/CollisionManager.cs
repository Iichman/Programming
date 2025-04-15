using System;

namespace Programming.Model
{
    public static class CollisionManager
    {
        public static bool IsCollision(Rectangle rect1, Rectangle rect2)
        {
            if (rect1 == null || rect2 == null)
                return false;

            double dx = Math.Abs(rect1.Center.X - rect2.Center.X);
            double dy = Math.Abs(rect1.Center.Y - rect2.Center.Y);

            double sumHalfWidths = (rect1.Width + rect2.Width) / 2;
            double sumHalfHeights = (rect1.Length + rect2.Length) / 2;

            return dx < sumHalfWidths && dy < sumHalfHeights;
        }
    }
}