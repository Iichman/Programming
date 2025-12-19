using System;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет корзину покупателя.
    /// </summary>
    public class Cart : ICloneable
    {
        /// <summary>
        /// Список товаров в корзине.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Создает новую корзину.
        /// </summary>
        public Cart()
        {
            Items = new List<Item>();
        }

        /// <summary>
        /// Создает корзину с заданными товарами.
        /// </summary>
        public Cart(List<Item> items)
        {
            Items = items ?? new List<Item>();
        }

        /// <summary>
        /// Добавляет товар в корзину.
        /// </summary>
        public void AddItem(Item item)
        {
            if (item != null)
            {
                Items.Add(item);
            }
        }

        /// <summary>
        /// Удаляет товар из корзины.
        /// </summary>
        public void RemoveItem(Item item)
        {
            if (item != null)
            {
                Items.Remove(item);
            }
        }

        /// <summary>
        /// Очищает корзину.
        /// </summary>
        public void Clear()
        {
            Items.Clear();
        }

        /// <summary>
        /// Создает копию корзины.
        /// </summary>
        public object Clone()
        {
            var clonedItems = new List<Item>();
            foreach (var item in Items)
            {
                clonedItems.Add((Item)item.Clone());
            }
            return new Cart(clonedItems);
        }

        /// <summary>
        /// Общая стоимость товаров в корзине.
        /// </summary>
        public decimal Amount
        {
            get
            {
                decimal total = 0;
                foreach (var item in Items)
                {
                    total += item.Cost;
                }
                return total;
            }
        }
    }
}