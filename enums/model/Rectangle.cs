using System;
using System.Drawing;
using System.Windows.Forms;

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

        public Rectangle(double length, double width, string color, Point2D center)
        {
            Id = _allRectanglesCount++;
            Length = length;
            Width = width;
            Color = color;
            Center = center;
        }

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

        public override string ToString()
        {
            return $"Rectangle {Id} (X={Center.X:F1}, Y={Center.Y:F1}, W={Width:F1}, H={Length:F1})";
        }
    }
}