using System;

namespace Programming.Model
{
    public static class CollisionManager
    {
        public static bool IsCollision(Rectangle rect1, Rectangle rect2)
        {
            // Расстояние между центрами по X
            double deltaX = Math.Abs(rect1.Center.X - rect2.Center.X);
            double sumWidth = (rect1.Width + rect2.Width) / 2;

            // Расстояние между центрами по Y
            double deltaY = Math.Abs(rect1.Center.Y - rect2.Center.Y);
            double sumLength = (rect1.Length + rect2.Length) / 2;

            // Проверка пересечения
            return deltaX <= sumWidth && deltaY <= sumLength;
        }
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double dx = ring1.Center.X - ring2.Center.X;
            double dy = ring1.Center.Y - ring2.Center.Y;
            double distance = Math.Sqrt(dx * dx + dy * dy);

            return distance < (ring1.OuterRadius + ring2.OuterRadius);
        }
    }
}