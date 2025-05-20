using System;

namespace Programming.Model
{
    /// <summary>
    /// ������������� ������ ��� �������� ������� ������.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// ���������, ��� ����� ����� �������� �������������.
        /// </summary>
        /// <param name="value">����������� ��������.</param>
        /// <param name="propertyName">��� ��������.</param>
        /// <returns>����������� ��������.</returns>
        /// <exception cref="ArgumentException">�������������, ���� �������� �� �������������.</exception>
        public static int AssertOnPositiveValue(int value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException(
                    $"{propertyName} ������ ���� �������������. ��������: {value}");
            }
            return value;
        }

        public static void AssertStringNotNullOrEmpty(string value, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{propertyName} cannot be null or empty");
            }
        }

        /// <summary>
        /// ���������, ��� ������������ ����� �������� �������������.
        /// </summary>
        /// <param name="value">����������� ��������.</param>
        /// <param name="propertyName">��� ��������.</param>
        /// <returns>����������� ��������.</returns>
        /// <exception cref="ArgumentException">�������������, ���� �������� �� �������������.</exception>
        public static double AssertOnPositiveValue(double value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException(
                    $"{propertyName} ������ ���� �������������. ��������: {value}");
            }
            return value;
        }

        /// <summary>
        /// ���������, ��� ����� ����� ��������� � �������� ���������.
        /// </summary>
        /// <param name="value">����������� ��������.</param>
        /// <param name="min">����������� ���������� ��������.</param>
        /// <param name="max">������������ ���������� ��������.</param>
        /// <param name="propertyName">��� ��������.</param>
        /// <returns>����������� ��������.</returns>
        /// <exception cref="ArgumentException">�������������, ���� �������� ��� ���������.</exception>
        public static int AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"{propertyName} ������ ���� � ��������� �� {min} �� {max}. ��������: {value}");
            }
            return value;
        }

        /// <summary>
        /// ���������, ��� ������������ ����� ��������� � �������� ���������.
        /// </summary>
        /// <param name="value">����������� ��������.</param>
        /// <param name="min">����������� ���������� ��������.</param>
        /// <param name="max">������������ ���������� ��������.</param>
        /// <param name="propertyName">��� ��������.</param>
        /// <returns>����������� ��������.</returns>
        /// <exception cref="ArgumentException">�������������, ���� �������� ��� ���������.</exception>
        public static double AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"{propertyName} ������ ���� � ��������� �� {min} �� {max}. ��������: {value}");
            }
            return value;
        }

        /// <summary>
        /// ���������, ��� ������ ������� ������ �� ���� ����������� ��������.
        /// </summary>
        /// <param name="value">����������� ������.</param>
        /// <param name="propertyName">��� ��������.</param>
        /// <returns>����������� ������.</returns>
        /// <exception cref="ArgumentException">�������������, ���� ������ �������� ������������ �������.</exception>
        public static string AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                    $"{propertyName} �� ����� ���� ������ ��� ��������� ������ �������");
            }

            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                {
                    throw new ArgumentException(
                        $"{propertyName} ������ ��������� ������ ����� ����������� ��������. ��������: {value}");
                }
            }

            return value;
        }
    }
}