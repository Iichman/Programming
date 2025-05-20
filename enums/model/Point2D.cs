using System;

namespace Programming.Model
{
    /// <summary>
    /// Представляет точку в двумерном пространстве с координатами X и Y.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Возвращает или задает координату X точки.
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Возвращает или задает координату Y точки.
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Point2D"/> с заданными координатами.
        /// </summary>
        /// <param name="x">Координата X точки.</param>
        /// <param name="y">Координата Y точки.</param>
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Возвращает строковое представление точки в формате "(X; Y)".
        /// </summary>
        /// <returns>Строка, представляющая текущую точку с координатами, округленными до 2 знаков после запятой.</returns>
        public override string ToString()
        {
            return $"({X:F2}; {Y:F2})";
        }
    }
}