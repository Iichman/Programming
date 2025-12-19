using System;
using System.Collections.Generic;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет заказ.
    /// </summary>
    public class Order : IEquatable<Order>
    {
        /// <summary>
        /// Уникальный идентификатор заказа.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Дата создания заказа.
        /// </summary>
        public DateTime Date { get; private set; }

        /// <summary>
        /// Адрес доставки заказа.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Список товаров в заказе.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Статус заказа.
        /// </summary>
        public OrderStatus Status { get; set; }

        /// <summary>
        /// Сумма скидки.
        /// </summary>
        public decimal DiscountAmount { get; set; }

        /// <summary>
        /// Создает новый заказ.
        /// </summary>
        public Order()
        {
            Id = IdGenerator.GetNextOrderId();
            Date = DateTime.Now;
            Status = OrderStatus.New;
            Address = new Address();
            Items = new List<Item>();
        }

        /// <summary>
        /// Создает заказ с заданными параметрами.
        /// </summary>
        public Order(List<Item> items, Address address)
        {
            Id = IdGenerator.GetNextOrderId();
            Date = DateTime.Now;
            Status = OrderStatus.New;
            Items = items ?? new List<Item>();
            Address = address ?? new Address();
        }

        /// <summary>
        /// Общая стоимость заказа.
        /// </summary>
        public decimal Amount
        {
            get
            {
                decimal total = 0;
                if (Items != null)
                {
                    foreach (var item in Items)
                    {
                        total += item.Cost;
                    }
                }
                return total;
            }
        }

        /// <summary>
        /// Общая сумма с учетом скидки.
        /// </summary>
        public decimal Total
        {
            get
            {
                return Amount - DiscountAmount;
            }
        }

        /// <summary>
        /// Сравнивает текущий заказ с другим заказом.
        /// </summary>
        public bool Equals(Order other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return Id == other.Id && Date == other.Date;
        }

        /// <summary>
        /// Сравнивает текущий заказ с другим объектом.
        /// </summary>
        public override bool Equals(object obj)
        {
            return Equals(obj as Order);
        }

        /// <summary>
        /// Возвращает хэш-код заказа.
        /// </summary>
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Date);
        }

        /// <summary>
        /// Проверяет равенство двух заказов.
        /// </summary>
        public static bool operator ==(Order left, Order right)
        {
            if (ReferenceEquals(left, right)) return true;
            if (left is null || right is null) return false;
            return left.Equals(right);
        }

        /// <summary>
        /// Проверяет неравенство двух заказов.
        /// </summary>
        public static bool operator !=(Order left, Order right)
        {
            return !(left == right);
        }

        /// <summary>
        /// Возвращает строковое представление заказа.
        /// </summary>
        public override string ToString()
        {
            return $"Order #{Id} - {Date:dd.MM.yyyy} - {Amount:C}";
        }
    }
}