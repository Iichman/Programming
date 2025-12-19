using System;
using System.Collections.Generic;
using System.Linq;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Представляет процентную скидку на конкретную категорию товаров.
    /// </summary>
    public class PercentDiscount : IDiscount, IComparable<PercentDiscount>
    {
        private Category _category;
        private decimal _accumulatedAmount;
        private int _percent;

        /// <summary>
        /// Категория товаров для скидки.
        /// </summary>
        public Category Category
        {
            get { return _category; }
            private set { _category = value; }
        }

        /// <summary>
        /// Накопленная сумма покупок в категории.
        /// </summary>
        public decimal AccumulatedAmount
        {
            get { return _accumulatedAmount; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Накопленная сумма не может быть отрицательной");
                }
                _accumulatedAmount = value;
            }
        }

        /// <summary>
        /// Процент скидки (от 1% до 10%).
        /// </summary>
        public int Percent
        {
            get { return _percent; }
            private set
            {
                _percent = Math.Max(1, Math.Min(10, value));
            }
        }

        /// <summary>
        /// Создает процентную скидку на категорию товаров.
        /// </summary>
        public PercentDiscount(Category category)
        {
            Category = category;
            AccumulatedAmount = 0;
            Percent = 1;
        }

        /// <summary>
        /// Создает процентную скидку с заданными параметрами.
        /// </summary>
        public PercentDiscount(Category category, decimal accumulatedAmount, int percent)
        {
            Category = category;
            AccumulatedAmount = accumulatedAmount;
            Percent = percent;
        }

        /// <summary>
        /// Информация о скидке.
        /// </summary>
        public string Info
        {
            get { return $"Процентная \"{Category}\" - {Percent}%"; }
        }

        /// <summary>
        /// Вычисляет размер скидки для списка товаров.
        /// </summary>
        public decimal Calculate(List<Item> items)
        {
            if (items == null || items.Count == 0) return 0;

            var categoryItems = items.Where(item => item.Category == Category).ToList();
            if (categoryItems.Count == 0) return 0;

            decimal categoryAmount = categoryItems.Sum(item => item.Cost);
            return categoryAmount * Percent / 100m;
        }

        /// <summary>
        /// Применяет скидку к списку товаров.
        /// </summary>
        public decimal Apply(List<Item> items)
        {
            return Calculate(items);
        }

        /// <summary>
        /// Обновляет данные скидки на основе покупки.
        /// </summary>
        public void Update(List<Item> items)
        {
            if (items == null || items.Count == 0) return;

            var categoryItems = items.Where(item => item.Category == Category).ToList();
            if (categoryItems.Count == 0) return;

            decimal categoryAmount = categoryItems.Sum(item => item.Cost);
            AccumulatedAmount += categoryAmount;

            // Каждые 1000 рублей = +1% (максимум 10%)
            int newPercent = 1 + (int)(AccumulatedAmount / 1000);
            Percent = newPercent;
        }

        /// <summary>
        /// Сравнивает текущую скидку с другой.
        /// </summary>
        public int CompareTo(PercentDiscount other)
        {
            if (other == null) return 1;
            return Percent.CompareTo(other.Percent);
        }
    }
}