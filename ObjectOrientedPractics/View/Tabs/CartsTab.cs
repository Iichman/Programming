using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Вкладка для управления корзинами покупателей.
    /// </summary>
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Текущий выбранный покупатель.
        /// </summary>
        private Customer? _currentCustomer;

        /// <summary>
        /// Создает экземпляр класса <see cref="CartsTab"/>.
        /// </summary>
        public CartsTab()
        {
            InitializeComponent();
            amountLabel.Text = "0.00";
        }

        /// <summary>
        /// Возвращает или задает список товаров.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value ?? new List<Item>();
                RefreshData();
            }
        }

        /// <summary>
        /// Возвращает или задает список покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value ?? new List<Customer>();
                RefreshData();
            }
        }

        /// <summary>
        /// Обновляет данные на вкладке.
        /// </summary>
        public void RefreshData()
        {
            // Обновляем список товаров
            itemsListBox.Items.Clear();
            foreach (var item in _items)
            {
                itemsListBox.Items.Add($"{item.Name} - {item.Cost:C}");
            }

            // Обновляем список покупателей
            customersComboBox.Items.Clear();
            foreach (var customer in _customers)
            {
                customersComboBox.Items.Add(customer.Fullname);
            }

            // Сбрасываем текущего покупателя
            _currentCustomer = null;
            customersComboBox.SelectedIndex = -1;
            cartListBox.Items.Clear();
            amountLabel.Text = "0.00";
        }

        /// <summary>
        /// Обновляет отображение корзины текущего покупателя.
        /// </summary>
        private void UpdateCartDisplay()
        {
            cartListBox.Items.Clear();
            if (_currentCustomer != null && _currentCustomer.Cart != null)
            {
                foreach (var item in _currentCustomer.Cart.Items)
                {
                    cartListBox.Items.Add($"{item.Name} - {item.Cost:C}");
                }
                amountLabel.Text = _currentCustomer.Cart.Amount.ToString("F2");
            }
            else
            {
                amountLabel.Text = "0.00";
            }
        }

        /// <summary>
        /// Обработчик изменения выбранного покупателя.
        /// </summary>
        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customersComboBox.SelectedIndex >= 0 && customersComboBox.SelectedIndex < _customers.Count)
            {
                _currentCustomer = _customers[customersComboBox.SelectedIndex];
                UpdateCartDisplay();
            }
            else
            {
                _currentCustomer = null;
                cartListBox.Items.Clear();
                amountLabel.Text = "0.00";
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки добавления товара в корзину.
        /// </summary>
        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null)
            {
                MessageBox.Show("Please select a customer first.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (itemsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item to add to cart.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedItem = _items[itemsListBox.SelectedIndex];
            _currentCustomer.Cart.Items.Add(selectedItem);
            UpdateCartDisplay();
        }

        /// <summary>
        /// Обработчик нажатия кнопки удаления товара из корзины.
        /// </summary>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null || cartListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a customer and item to remove.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _currentCustomer.Cart.Items.RemoveAt(cartListBox.SelectedIndex);
            UpdateCartDisplay();
        }

        /// <summary>
        /// Обработчик нажатия кнопки очистки корзины.
        /// </summary>
        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null)
            {
                MessageBox.Show("Please select a customer first.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _currentCustomer.Cart.Items.Clear();
            UpdateCartDisplay();
        }

        /// <summary>
        /// Обработчик нажатия кнопки создания заказа.
        /// </summary>
        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null)
            {
                MessageBox.Show("Please select a customer first.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_currentCustomer.Cart.Items.Count == 0)
            {
                MessageBox.Show("Cart is empty. Add items to cart before creating an order.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Создаем новый заказ
                int orderId = _currentCustomer.Orders.Count + 1;
                var orderItems = new List<Item>(_currentCustomer.Cart.Items);
                var order = new Order(orderId, _currentCustomer.Address, orderItems);

                // Добавляем заказ в список заказов покупателя
                _currentCustomer.Orders.Add(order);

                // Очищаем корзину
                _currentCustomer.Cart.Items.Clear();

                UpdateCartDisplay();

                MessageBox.Show($"Order #{order.Id} created successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating order: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}