using System;

namespace Programming.Model
{
    public class Rectangle
    {
        private double _length;
        private double _width;
        private string _color;

        public Rectangle(double length, double width, string color)
        {
            Length = length;
            Width = width;
            Color = color;
        }

        public Rectangle()
        {
            // Конструктор без аргументов
        }

        public double Length
        {
            get { return _length; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Length cannot be negative.");
                _length = value;
            }
        }

        public double Width
        {
            get { return _width; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Width cannot be negative.");
                _width = value;
            }
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
    }
}