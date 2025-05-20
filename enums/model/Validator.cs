using System;

namespace Programming.Model
{
    /// <summary>
    /// Предоставляет методы для проверки входных данных.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет, что целое число является положительным.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="propertyName">Имя свойства.</param>
        /// <returns>Проверенное значение.</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если значение не положительное.</exception>
        public static int AssertOnPositiveValue(int value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException(
                    $"{propertyName} должно быть положительным. Получено: {value}");
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
        /// Проверяет, что вещественное число является положительным.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="propertyName">Имя свойства.</param>
        /// <returns>Проверенное значение.</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если значение не положительное.</exception>
        public static double AssertOnPositiveValue(double value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException(
                    $"{propertyName} должно быть положительным. Получено: {value}");
            }
            return value;
        }

        /// <summary>
        /// Проверяет, что целое число находится в заданном диапазоне.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Минимальное допустимое значение.</param>
        /// <param name="max">Максимальное допустимое значение.</param>
        /// <param name="propertyName">Имя свойства.</param>
        /// <returns>Проверенное значение.</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если значение вне диапазона.</exception>
        public static int AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"{propertyName} должно быть в диапазоне от {min} до {max}. Получено: {value}");
            }
            return value;
        }

        /// <summary>
        /// Проверяет, что вещественное число находится в заданном диапазоне.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Минимальное допустимое значение.</param>
        /// <param name="max">Максимальное допустимое значение.</param>
        /// <param name="propertyName">Имя свойства.</param>
        /// <returns>Проверенное значение.</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если значение вне диапазона.</exception>
        public static double AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"{propertyName} должно быть в диапазоне от {min} до {max}. Получено: {value}");
            }
            return value;
        }

        /// <summary>
        /// Проверяет, что строка состоит только из букв английского алфавита.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="propertyName">Имя свойства.</param>
        /// <returns>Проверенная строка.</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если строка содержит недопустимые символы.</exception>
        public static string AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                    $"{propertyName} не может быть пустым или содержать только пробелы");
            }

            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                {
                    throw new ArgumentException(
                        $"{propertyName} должно содержать только буквы английского алфавита. Получено: {value}");
                }
            }

            return value;
        }
    }
}