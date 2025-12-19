using System.Collections.Generic;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Интерфейс для скидок.
    /// </summary>
    public interface IDiscount
    {
        /// <summary>
        /// Информация о скидке.
        /// </summary>
        string Info { get; }

        /// <summary>
        /// Вычисляет размер скидки для списка товаров.
        /// </summary>
        decimal Calculate(List<Item> items);

        /// <summary>
        /// Применяет скидку к списку товаров.
        /// </summary>
        decimal Apply(List<Item> items);

        /// <summary>
        /// Обновляет данные скидки на основе покупки.
        /// </summary>
        void Update(List<Item> items);
    }
}