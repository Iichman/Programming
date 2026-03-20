using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;

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
        /// <typeparam name="T">Тип элементов списка.</typeparam>
        /// <param name="items">Исходный список элементов.</param>
        /// <param name="predicate">Предикат для фильтрации.</param>
        /// <returns>Отфильтрованный список элементов.</returns>
        public static List<T> Filter<T>(List<T> items, Func<T, bool> predicate)
        {
            if (items == null) throw new ArgumentNullException(nameof(items));
            if (predicate == null) throw new ArgumentNullException(nameof(predicate));

            var result = new List<T>();
            foreach (var item in items)
            {
                if (item != null && predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        /// <summary>
        /// Сортирует список элементов по условию.
        /// </summary>
        /// <typeparam name="T">Тип элементов списка.</typeparam>
        /// <param name="items">Исходный список элементов.</param>
        /// <param name="comparer">Функция сравнения двух элементов.</param>
        /// <returns>Отсортированный список элементов.</returns>
        public static List<T> Sort<T>(List<T> items, Func<T, T, int> comparer)
        {
            if (items == null) throw new ArgumentNullException(nameof(items));
            if (comparer == null) throw new ArgumentNullException(nameof(comparer));

            var result = new List<T>(items);

            for (int i = 0; i < result.Count - 1; i++)
            {
                for (int j = 0; j < result.Count - i - 1; j++)
                {
                    if (comparer(result[j], result[j + 1]) > 0)
                    {
                        var temp = result[j];
                        result[j] = result[j + 1];
                        result[j + 1] = temp;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Проверяет, содержит ли название товара указанный текст.
        /// </summary>
        /// <param name="item">Товар для проверки.</param>
        /// <param name="searchText">Текст для поиска.</param>
        /// <returns>True если название содержит текст, иначе False.</returns>
        public static bool FilterByNameContains(Item item, string searchText)
        {
            if (item == null || string.IsNullOrEmpty(item.Name) || string.IsNullOrEmpty(searchText))
                return false;

            return item.Name.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        /// <summary>
        /// Проверяет, превышает ли цена товара 5000.
        /// </summary>
        /// <param name="item">Товар для проверки.</param>
        /// <returns>True если цена больше 5000, иначе False.</returns>
        public static bool FilterByPriceAbove5000(Item item)
        {
            if (item == null) return false;
            return item.Cost > 5000m;
        }

        /// <summary>
        /// Проверяет, относится ли товар к указанной категории.
        /// </summary>
        /// <param name="item">Товар для проверки.</param>
        /// <param name="category">Категория для сравнения.</param>
        /// <returns>True если товар относится к категории, иначе False.</returns>
        public static bool FilterByCategory(Item item, Category category)
        {
            if (item == null) return false;
            return item.Category == category;
        }

        /// <summary>
        /// Сравнивает два товара по названию.
        /// </summary>
        public static int CompareByName(Item x, Item y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;

            return string.Compare(x.Name, y.Name, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Сравнивает два товара по возрастанию цены.
        /// </summary>
        public static int CompareByCostAscending(Item x, Item y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;

            return x.Cost.CompareTo(y.Cost);
        }

        /// <summary>
        /// Сравнивает два товара по убыванию цены.
        /// </summary>
        public static int CompareByCostDescending(Item x, Item y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return 1;
            if (y == null) return -1;

            return y.Cost.CompareTo(x.Cost);
        }

        /// <summary>
        /// Сравнивает два товара по категории.
        /// </summary>
        public static int CompareByCategory(Item x, Item y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;

            return string.Compare(x.Category.ToString(), y.Category.ToString(),
                StringComparison.OrdinalIgnoreCase);
        }
    }
}