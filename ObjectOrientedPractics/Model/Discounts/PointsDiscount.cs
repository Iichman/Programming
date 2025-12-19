using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Представляет скидку на накопительные баллы.
    /// </summary>
    public class PointsDiscount : IDiscount, IComparable<PointsDiscount>
    {
        private int _points;

        /// <summary>
        /// Количество накопленных баллов.
        /// </summary>
        public int Points
        {
            get { return _points; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Количество баллов не может быть отрицательным");
                }
                _points = value;
            }
        }

        /// <summary>
        /// Создает скидку на накопительные баллы.
        /// </summary>
        public PointsDiscount()
        {
            Points = 0;
        }

        /// <summary>
        /// Создает скидку на накопительные баллы с заданным количеством баллов.
        /// </summary>
        public PointsDiscount(int points)
        {
            Points = points;
        }

        /// <summary>
        /// Информация о скидке.
        /// </summary>
        public string Info
        {
            get { return $"Накопительная – {Points} баллов"; }
        }

        /// <summary>
        /// Вычисляет размер скидки для списка товаров.
        /// </summary>
        public decimal Calculate(List<Item> items)
        {
            if (items == null || items.Count == 0) return 0;

            decimal totalAmount = items.Sum(item => item.Cost);
            decimal maxDiscount = totalAmount * 0.3m; // 30% максимум
            decimal availableDiscount = Math.Min(Points, maxDiscount);

            return availableDiscount;
        }

        /// <summary>
        /// Применяет скидку к списку товаров.
        /// </summary>
        public decimal Apply(List<Item> items)
        {
            if (items == null || items.Count == 0) return 0;

            decimal totalAmount = items.Sum(item => item.Cost);
            decimal maxDiscount = totalAmount * 0.3m;
            decimal discountToApply = Math.Min(Points, maxDiscount);

            // Списание баллов (1 балл = 1 рубль)
            Points -= (int)Math.Ceiling(discountToApply);
            return discountToApply;
        }

        /// <summary>
        /// Обновляет данные скидки на основе покупки.
        /// </summary>
        public void Update(List<Item> items)
        {
            if (items == null || items.Count == 0) return;

            decimal totalAmount = items.Sum(item => item.Cost);
            int pointsToAdd = (int)Math.Ceiling(totalAmount * 0.1m); // 10% от покупки
            Points += pointsToAdd;
        }

        /// <summary>
        /// Сравнивает текущую скидку с другой.
        /// </summary>
        public int CompareTo(PointsDiscount other)
        {
            if (other == null) return 1;
            return Points.CompareTo(other.Points);
        }
    }
}