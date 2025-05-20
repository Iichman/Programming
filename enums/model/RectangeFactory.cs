using System;
using Programming.Model;

namespace Programming.Model.Factories
{
    /// <summary>
    /// Фабрика для создания прямоугольников со случайными параметрами.
    /// </summary>
    public static class RectangleFactory
    {
        private static Random _random = new Random();

        /// <summary>
        /// Создает прямоугольник со случайными параметрами в пределах указанной области.
        /// </summary>
        /// <param name="canvasWidth">Ширина области для размещения прямоугольника.</param>
        /// <param name="canvasHeight">Высота области для размещения прямоугольника.</param>
        /// <returns>Новый экземпляр <see cref="Rectangle"/> со случайными параметрами.</returns>
        /// <exception cref="ArgumentException">
        /// Возникает, если canvasWidth или canvasHeight меньше или равны 0.
        /// </exception>
        public static Rectangle Randomize(int canvasWidth, int canvasHeight)
        {
            if (canvasWidth <= 0)
                throw new ArgumentException("Canvas width must be positive", nameof(canvasWidth));
            if (canvasHeight <= 0)
                throw new ArgumentException("Canvas height must be positive", nameof(canvasHeight));

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