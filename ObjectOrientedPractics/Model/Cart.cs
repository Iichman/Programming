using System.Collections.Generic;
using System.Linq;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет корзину товаров покупателя.
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// Список товаров в корзине.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Создает экземпляр класса <see cref="Cart"/> с пустым списком товаров.
        /// </summary>
        public Cart()
        {
            _items = new List<Item>();
        }

        /// <summary>
        /// Возвращает или задает список товаров в корзине.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value ?? new List<Item>(); }
        }

        /// <summary>
        /// Возвращает общую стоимость всех товаров в корзине.
        /// Если список пустой или равен null, возвращает 0.0.
        /// </summary>
        public double Amount
        {
            get
            {
                if (_items == null || _items.Count == 0)
                    return 0.0;

                return _items.Sum(item => item.Cost);
            }
        }
    }
}