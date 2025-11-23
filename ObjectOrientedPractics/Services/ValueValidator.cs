using System;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Валидатор значений.
    /// </summary>
    public static class ValueValidator
    {
        /// <summary>
        /// Проверяет длину строки.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="maxLength">Максимальная длина.</param>
        /// <param name="propertyName">Имя свойства.</param>
        /// <returns>True если проверка пройдена, false если есть ошибка.</returns>
        public static bool ValidateStringLength(string value, int maxLength, string propertyName)
        {
            if (value != null && value.Length > maxLength)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Проверяет длину строки и выбрасывает исключение при ошибке.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="maxLength">Максимальная длина.</param>
        /// <param name="propertyName">Имя свойства.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если длина строки превышает максимальную.</exception>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value != null && value.Length > maxLength)
            {
                throw new ArgumentException(
                    $"{propertyName} должен быть меньше {maxLength} символов.");
            }
        }

        /// <summary>
        /// Проверяет, что стоимость не отрицательная.
        /// </summary>
        /// <param name="value">Проверяемая стоимость.</param>
        /// <param name="propertyName">Имя свойства.</param>
        /// <returns>True если проверка пройдена, false если есть ошибка.</returns>
        public static bool ValidateCostNotNegative(double value, string propertyName)
        {
            return value >= 0;
        }

        /// <summary>
        /// Проверяет, что стоимость находится в допустимом диапазоне.
        /// </summary>
        /// <param name="value">Проверяемая стоимость.</param>
        /// <param name="minValue">Минимальное значение.</param>
        /// <param name="maxValue">Максимальное значение.</param>
        /// <param name="propertyName">Имя свойства.</param>
        /// <returns>True если проверка пройдена, false если есть ошибка.</returns>
        public static bool ValidateCostInRange(double value, double minValue, double maxValue, string propertyName)
        {
            return value >= minValue && value <= maxValue;
        }
    }
}