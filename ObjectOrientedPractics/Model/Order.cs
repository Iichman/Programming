using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет заказ.
    /// </summary>
    public class Order
    {
        private readonly int _id;
        private readonly DateTime _date;
        private Address _address;
        private List<Item> _items;
        private OrderStatus _status;

        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="id">Уникальный идентификатор заказа.</param>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Список товаров в заказе.</param>
        public Order(int id, Address address, List<Item> items)
        {
            _id = id;
            _date = DateTime.Now;
            _address = address ?? new Address();
            _items = items ?? new List<Item>();
            _status = OrderStatus.New;
        }

        /// <summary>
        /// Возвращает идентификатор заказа.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Возвращает дату создания заказа.
        /// </summary>
        public DateTime Date
        {
            get { return _date; }
        }

        /// <summary>
        /// Возвращает или задает адрес доставки заказа.
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set { _address = value ?? new Address(); }
        }

        /// <summary>
        /// Возвращает или задает список товаров в заказе.
        /// Агрегация: товары могут существовать независимо от заказа.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value ?? new List<Item>(); }
        }

        /// <summary>
        /// Возвращает или задает статус заказа.
        /// </summary>
        public OrderStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        /// Возвращает общую стоимость заказа.
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