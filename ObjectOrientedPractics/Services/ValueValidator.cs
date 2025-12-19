using System;
using System.Text.RegularExpressions;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет методы для валидации значений.
    /// </summary>
    public static class ValueValidator
    {
        /// <summary>
        /// Проверяет, что строка не превышает максимальную длину.
        /// </summary>
        /// <param name="value">Строка для проверки.</param>
        /// <param name="maxLength">Максимальная допустимая длина.</param>
        /// <param name="propertyName">Имя свойства для сообщения об ошибке.</param>
        /// <exception cref="ArgumentException">
        /// Выбрасывается, если длина строки превышает максимальную.
        /// </exception>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value == null) return;

            if (value.Length > maxLength)
            {
                throw new ArgumentException(
                    $"{propertyName} должен содержать не более {maxLength} символов. Текущая длина: {value.Length}.");
            }
        }

        /// <summary>
        /// Проверяет, что стоимость находится в указанном диапазоне (double).
        /// </summary>
        /// <param name="value">Значение стоимости.</param>
        /// <param name="min">Минимальное значение.</param>
        /// <param name="max">Максимальное значение.</param>
        /// <param name="propertyName">Имя свойства для сообщения об ошибке.</param>
        /// <exception cref="ArgumentException">
        /// Выбрасывается, если значение выходит за границы диапазона.
        /// </exception>
        public static void AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"{propertyName} должен быть в диапазоне от {min} до {max}. Текущее значение: {value}.");
            }
        }

        /// <summary>
        /// Проверяет, что стоимость находится в указанном диапазоне (decimal).
        /// </summary>
        /// <param name="value">Значение стоимости.</param>
        /// <param name="min">Минимальное значение.</param>
        /// <param name="max">Максимальное значение.</param>
        /// <param name="propertyName">Имя свойства для сообщения об ошибке.</param>
        /// <exception cref="ArgumentException">
        /// Выбрасывается, если значение выходит за границы диапазона.
        /// </exception>
        public static void AssertValueInRange(decimal value, decimal min, decimal max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"{propertyName} должен быть в диапазоне от {min} до {max}. Текущее значение: {value}.");
            }
        }

        /// <summary>
        /// Проверяет, что индекс является шестизначным числом.
        /// </summary>
        /// <param name="value">Строка индекса.</param>
        /// <param name="propertyName">Имя свойства для сообщения об ошибке.</param>
        /// <exception cref="ArgumentException">
        /// Выбрасывается, если индекс не является шестизначным числом.
        /// </exception>
        public static void AssertPostIndex(string value, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{propertyName} не может быть пустым.");
            }

            if (!int.TryParse(value, out int index))
            {
                throw new ArgumentException($"{propertyName} должен содержать только цифры.");
            }

            if (value.Length != 6)
            {
                throw new ArgumentException($"{propertyName} должен содержать 6 цифр.");
            }
        }

        /// <summary>
        /// Проверяет, что строка не пустая и не превышает максимальную длину.
        /// </summary>
        /// <param name="value">Строка для проверки.</param>
        /// <param name="maxLength">Максимальная допустимая длина.</param>
        /// <param name="propertyName">Имя свойства для сообщения об ошибке.</param>
        /// <exception cref="ArgumentException">
        /// Выбрасывается, если строка пустая или превышает максимальную длину.
        /// </exception>
        public static void AssertStringNotNullOrEmpty(string value, int maxLength, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{propertyName} не может быть пустым.");
            }

            AssertStringOnLength(value, maxLength, propertyName);
        }

        /// <summary>
        /// Проверяет, что строка содержит только буквы, пробелы и дефисы.
        /// </summary>
        /// <param name="value">Строка для проверки.</param>
        /// <param name="propertyName">Имя свойства для сообщения об ошибке.</param>
        /// <exception cref="ArgumentException">
        /// Выбрасывается, если строка содержит недопустимые символы.
        /// </exception>
        public static void AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(value)) return;

            if (!Regex.IsMatch(value, @"^[a-zA-Zа-яА-ЯёЁ\s\-\']+$"))
            {
                throw new ArgumentException(
                    $"{propertyName} может содержать только буквы, пробелы, дефисы и апострофы.");
            }
        }

        /// <summary>
        /// Проверяет, что строка не пустая.
        /// </summary>
        /// <param name="value">Строка для проверки.</param>
        /// <param name="propertyName">Имя свойства для сообщения об ошибке.</param>
        /// <exception cref="ArgumentException">
        /// Выбрасывается, если строка пустая.
        /// </exception>
        public static void AssertStringNotEmpty(string value, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{propertyName} не может быть пустым.");
            }
        }
    }
}