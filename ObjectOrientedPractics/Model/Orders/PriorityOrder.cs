using System;
using System.Collections.Generic;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет приоритетный заказ.
    /// </summary>
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Время доставки.
        /// </summary>
        public DeliveryTime DeliveryTime { get; set; }

        /// <summary>
        /// Желаемая дата доставки.
        /// </summary>
        public DateTime DesiredDeliveryDate { get; set; }

        /// <summary>
        /// Создает новый приоритетный заказ.
        /// </summary>
        public PriorityOrder() : base()
        {
            DesiredDeliveryDate = DateTime.Now.AddDays(1);
            DeliveryTime = DeliveryTime.NineToEleven;
        }

        /// <summary>
        /// Создает приоритетный заказ с заданными параметрами.
        /// </summary>
        public PriorityOrder(List<Item> items, Address address, DeliveryTime deliveryTime, DateTime desiredDate)
            : base(items, address)
        {
            DeliveryTime = deliveryTime;
            DesiredDeliveryDate = desiredDate;
        }

        /// <summary>
        /// Возвращает строковое представление приоритетного заказа.
        /// </summary>
        public override string ToString()
        {
            return $"Priority Order #{Id} - {Date:dd.MM.yyyy} - {Amount:C}";
        }
    }
}