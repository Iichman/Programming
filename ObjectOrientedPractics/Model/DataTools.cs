using System;
using System.Collections.Generic;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет методы для работы с данными.
    /// </summary>
    public static class DataTools
    {
        /// <summary>
        /// Фильтрует список элементов по условию.
        /// </summary>
        public static List<T> FilterFunc<T>(List<T> items, Func<T, bool> predicate)
        {
            var result = new List<T>();
            foreach (var item in items)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        /// <summary>
        /// Сортирует список элементов по условию.
        /// </summary>
        public static List<T> SortFunc<T>(List<T> items, Func<T, T, int> comparer)
        {
            var result = new List<T>(items);
            result.Sort((x, y) => comparer(x, y));
            return result;
        }

        /// <summary>
        /// Сравнивает товары по имени.
        /// </summary>
        public static int CompareByName(Item x, Item y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;
            return string.Compare(x.Name, y.Name, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Сравнивает товары по возрастанию стоимости.
        /// </summary>
        public static int CompareByCostAscending(Item x, Item y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;
            return x.Cost.CompareTo(y.Cost);
        }

        /// <summary>
        /// Сравнивает товары по убыванию стоимости.
        /// </summary>
        public static int CompareByCostDescending(Item x, Item y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return 1;
            if (y == null) return -1;
            return y.Cost.CompareTo(x.Cost);
        }
    }
}