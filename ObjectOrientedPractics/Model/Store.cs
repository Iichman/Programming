using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет магазин, содержащий списки товаров и покупателей.
    /// </summary>
    public class Store
    {
        /// <summary>
        /// Список товаров магазина.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Список покупателей магазина.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Создает экземпляр класса <see cref="Store"/> с пустыми списками товаров и покупателей.
        /// </summary>
        public Store()
        {
            _items = new List<Item>();
            _customers = new List<Customer>();
        }

        /// <summary>
        /// Возвращает или задает список товаров магазина.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value ?? new List<Item>(); }
        }

        /// <summary>
        /// Возвращает или задает список покупателей магазина.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value ?? new List<Customer>(); }
        }
    }
}