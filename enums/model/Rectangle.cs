using System;

namespace Programming.Model
{
    public class Rectangle
    {
        private static int _allRectanglesCount;
        private double _length;
        private double _width;

        public int Id { get; }
        public Point2D Center { get; set; }
        public string Color { get; set; }

        public double Length
        {
            get => _length;
            set
            {
                _length = Validator.AssertOnPositiveValue(value, nameof(Length));
            }
        }

        public double Width
        {
            get => _width;
            set
            {
                _width = Validator.AssertOnPositiveValue(value, nameof(Width));
            }
        }

        public event EventHandler OnCenterChanged;

        public Rectangle(double length, double width, string color)
        {
            Id = _allRectanglesCount++;
            Length = length;
            Width = width;
            Color = color;
            Center = new Point2D(width / 2, length / 2); // Центр по умолчанию
        }

        public override string ToString()
        {
            return $"Rectangle {Id} (L={_length:F2}, W={_width:F2}, Center={Center})";
        }
    }
}