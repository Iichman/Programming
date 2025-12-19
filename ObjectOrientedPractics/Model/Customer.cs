using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет покупателя.
    /// </summary>
    public class Customer
    {
        private int _id;
        private string _fullName;
        private Address _address;
        private Cart _cart;
        private List<Order> _orders;
        private List<IDiscount> _discounts;
        private bool _isPriority;

        /// <summary>
        /// Уникальный идентификатор покупателя.
        /// </summary>
        public int Id
        {
            get => _id;
            private set => _id = value;
        }

        /// <summary>
        /// Полное имя покупателя.
        /// </summary>
        public string FullName
        {
            get => _fullName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Имя не может быть пустым");
                if (value.Length > 200)
                    throw new ArgumentException("Имя не может быть длиннее 200 символов");
                _fullName = value;
            }
        }

        /// <summary>
        /// Адрес доставки покупателя.
        /// </summary>
        public Address Address
        {
            get => _address;
            set => _address = value;
        }

        /// <summary>
        /// Корзина покупателя.
        /// </summary>
        public Cart Cart
        {
            get => _cart;
            set => _cart = value;
        }

        /// <summary>
        /// Список заказов покупателя.
        /// </summary>
        public List<Order> Orders
        {
            get => _orders;
            set => _orders = value;
        }

        /// <summary>
        /// Список скидок покупателя.
        /// </summary>
        public List<IDiscount> Discounts
        {
            get => _discounts;
            set => _discounts = value;
        }

        /// <summary>
        /// Приоритетный покупатель.
        /// </summary>
        public bool IsPriority
        {
            get => _isPriority;
            set => _isPriority = value;
        }

        /// <summary>
        /// Создает нового покупателя.
        /// </summary>
        public Customer()
        {
            Id = IdGenerator.GetNextCustomerId();
            FullName = "Новый покупатель";
            Address = new Address();
            Cart = new Cart();
            Orders = new List<Order>();
            Discounts = new List<IDiscount>();
            Discounts.Add(new PointsDiscount());
            IsPriority = false;
        }

        /// <summary>
        /// Создает покупателя с заданными параметрами.
        /// </summary>
        public Customer(string fullName, Address address)
        {
            Id = IdGenerator.GetNextCustomerId();
            FullName = fullName;
            Address = address;
            Cart = new Cart();
            Orders = new List<Order>();
            Discounts = new List<IDiscount>();
            Discounts.Add(new PointsDiscount());
            IsPriority = false;
        }

        /// <summary>
        /// Возвращает строковое представление покупателя.
        /// </summary>
        public override string ToString()
        {
            return $"{FullName} (ID: {Id})";
        }
    }
}