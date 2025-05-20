using System;

namespace Programming.Model
{
    /// <summary>
    /// ������������ ����� � ��������� ������������ � ������������ X � Y.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// ���������� ��� ������ ���������� X �����.
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// ���������� ��� ������ ���������� Y �����.
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// �������������� ����� ��������� ������ <see cref="Point2D"/> � ��������� ������������.
        /// </summary>
        /// <param name="x">���������� X �����.</param>
        /// <param name="y">���������� Y �����.</param>
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// ���������� ��������� ������������� ����� � ������� "(X; Y)".
        /// </summary>
        /// <returns>������, �������������� ������� ����� � ������������, ������������ �� 2 ������ ����� �������.</returns>
        public override string ToString()
        {
            return $"({X:F2}; {Y:F2})";
        }
    }
}