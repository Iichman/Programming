using ObjectOrientedPractics.Services;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет покупателя.
    /// </summary>
    public class Customer
    {
        private readonly int _id;
        private string _fullname = "";
        private Address _address = new Address();
        private Cart _cart;
        private List<Order> _orders;

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        public Customer()
        {
            _id = IdGenerator.GetNextId();
            _cart = new Cart(); // Композиция: корзина создается вместе с покупателем
            _orders = new List<Order>();
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullname">Полное имя.</param>
        /// <param name="address">Адрес доставки.</param>
        public Customer(string fullname, Address address) : this()
        {
            Fullname = fullname;
            Address = address;
        }

        /// <summary>
        /// Возвращает идентификатор покупателя.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Возвращает или задает полное имя покупателя.
        /// </summary>
        public string Fullname
        {
            get { return _fullname; }
            set { _fullname = value; }
        }

        /// <summary>
        /// Возвращает или задает адрес доставки покупателя.
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set { _address = value ?? new Address(); }
        }

        /// <summary>
        /// Возвращает корзину покупателя.
        /// </summary>
        public Cart Cart
        {
            get { return _cart; }
        }

        /// <summary>
        /// Возвращает или задает список заказов покупателя.
        /// </summary>
        public List<Order> Orders
        {
            get { return _orders; }
            set { _orders = value ?? new List<Order>(); }
        }
    }
}