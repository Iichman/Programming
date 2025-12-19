using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Enums;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет магазин.
    /// </summary>
    public class Store
    {
        /// <summary>
        /// Список товаров в магазине.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Список покупателей магазина.
        /// </summary>
        public List<Customer> Customers { get; set; }

        /// <summary>
        /// Создает новый магазин с тестовыми данными.
        /// </summary>
        public Store()
        {
            Items = new List<Item>();
            Customers = new List<Customer>();

            InitializeTestData();
        }

        /// <summary>
        /// Инициализирует тестовые данные.
        /// </summary>
        private void InitializeTestData()
        {
            Items.Add(new Item("Ноутбук", "Игровой ноутбук", 85000, Category.Electronics));
            Items.Add(new Item("Смартфон", "Флагманский смартфон", 65000, Category.Electronics));
            Items.Add(new Item("Книга", "Программирование на C#", 1500, Category.Books));
            Items.Add(new Item("Футболка", "Хлопковая футболка", 1200, Category.Clothing));
            Items.Add(new Item("Кофе", "Арабика 1 кг", 2500, Category.Food));
            Items.Add(new Item("Стул", "Офисный стул", 5000, Category.Furniture));

            var address1 = new Address("123456", "Россия", "Москва", "Ленина", "15", "25");
            var address2 = new Address("654321", "Россия", "Санкт-Петербург", "Невский", "20", "10");

            var customer1 = new Customer("Иван Иванов", address1);
            var customer2 = new Customer("Мария Петрова", address2);

            customer1.Discounts.Add(new PercentDiscount(Category.Electronics));
            customer1.Discounts.Add(new PercentDiscount(Category.Books));

            customer2.IsPriority = true;
            customer2.Discounts.Add(new PercentDiscount(Category.Clothing));
            customer2.Discounts.Add(new PercentDiscount(Category.Food));

            Customers.Add(customer1);
            Customers.Add(customer2);
        }
    }
}