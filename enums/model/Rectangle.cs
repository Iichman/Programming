using System;
using System.Drawing;
using System.Windows.Forms;

namespace Programming.Model
{
    /// <summary>
    /// Представляет прямоугольник с заданными размерами, цветом и положением.
    /// </summary>
    public class Rectangle
    {
        private static int _allRectanglesCount;
        private double _length;
        private double _width;

        /// <summary>
        /// Уникальный идентификатор прямоугольника.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Центр прямоугольника.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Цвет прямоугольника.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Длина прямоугольника. Должна быть положительным числом.
        /// </summary>
        public double Length
        {
            get => _length;
            set => _length = Validator.AssertOnPositiveValue(value, nameof(Length));
        }

        /// <summary>
        /// Ширина прямоугольника. Должна быть положительным числом.
        /// </summary>
        public double Width
        {
            get => _width;
            set => _width = Validator.AssertOnPositiveValue(value, nameof(Width));
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="length">Длина прямоугольника.</param>
        /// <param name="width">Ширина прямоугольника.</param>
        /// <param name="color">Цвет прямоугольника.</param>
        /// <param name="center">Центр прямоугольника.</param>
        public Rectangle(double length, double width, string color, Point2D center)
        {
            Id = _allRectanglesCount++;
            Length = length;
            Width = width;
            Color = color;
            Center = center;
        }

        /// <summary>
        /// Создает панель Windows Forms для визуализации прямоугольника.
        /// </summary>
        /// <returns>Экземпляр <see cref="Panel"/>, представляющий прямоугольник.</returns>
        public Panel ToPanel()
        {
            return new Panel
            {
                Width = (int)Width,
                Height = (int)Length,
                Location = new Point((int)(Center.X - Width / 2), (int)(Center.Y - Length / 2)),
                BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127),
                BorderStyle = BorderStyle.FixedSingle,
                Tag = this
            };
        }

        /// <summary>
        /// Возвращает строковое представление прямоугольника.
        /// </summary>
        /// <returns>Строка с информацией о прямоугольнике.</returns>
        public override string ToString()
        {
            return $"Rectangle {Id} (X={Center.X:F1}, Y={Center.Y:F1}, W={Width:F1}, H={Length:F1})";
        }
    }
}