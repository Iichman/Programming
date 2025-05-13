using System;
using Programming.Model;

namespace Programming.Model.Factories
{
    public static class RectangleFactory
    {
        private static Random _random = new Random();

        public static Rectangle Randomize(int canvasWidth, int canvasHeight)
        {
            var width = _random.Next(30, 100);
            var length = _random.Next(30, 100);
            var x = _random.Next(width / 2, canvasWidth - width / 2);
            var y = _random.Next(length / 2, canvasHeight - length / 2);

            return new Rectangle(
                length,
                width,
                $"Color {_random.Next(1, 100)}",
                new Point2D(x, y));
        }
    }
}