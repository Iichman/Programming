using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Вкладка для работы с корзинами покупателей.
    /// </summary>
    public partial class CartsTab : UserControl
    {
        private List<Item> _items;
        private List<Customer> _customers;
        private Customer _currentCustomer;
        private bool _isInitialized = false;

        /// <summary>
        /// Событие создания заказа.
        /// </summary>
        public event EventHandler OrderCreated;

        /// <summary>
        /// Создает новый экземпляр класса <see cref="CartsTab"/>.
        /// </summary>
        public CartsTab()
        {
            InitializeComponent();
            _isInitialized = true;
            ConfigureControls();
        }

        /// <summary>
        /// Настраивает элементы управления.
        /// </summary>
        private void ConfigureControls()
        {
            discountsCheckedListBox.CheckOnClick = true;
            discountsCheckedListBox.SelectionMode = SelectionMode.One;

            discountsCheckedListBox.DisplayMember = "Info";

            createOrderButton.Enabled = false;
        }

        /// <summary>
        /// Список товаров.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value ?? new List<Item>();
                UpdateItemsListBox();
            }
        }

        /// <summary>
        /// Список покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value ?? new List<Customer>();
                UpdateCustomersComboBox();
            }
        }

        /// <summary>
        /// Обновляет данные на вкладке.
        /// </summary>
        public void RefreshData()
        {
            if (!_isInitialized) return;

            UpdateItemsListBox();
            UpdateCustomersComboBox();
        }

        /// <summary>
        /// Обновляет список товаров в ListBox.
        /// </summary>
        private void UpdateItemsListBox()
        {
            if (!_isInitialized) return;

            itemsListBox.BeginUpdate();
            itemsListBox.Items.Clear();

            if (_items != null)
            {
                foreach (var item in _items)
                {
                    itemsListBox.Items.Add($"{item.Name} - {item.Cost:C}");
                }
            }

            itemsListBox.EndUpdate();
        }

        /// <summary>
        /// Обновляет список покупателей в ComboBox.
        /// </summary>
        private void UpdateCustomersComboBox()
        {
            if (!_isInitialized) return;

            customersComboBox.BeginUpdate();
            customersComboBox.Items.Clear();

            if (_customers != null)
            {
                foreach (var customer in _customers)
                {
                    customersComboBox.Items.Add(customer.FullName);
                }
            }

            if (customersComboBox.Items.Count > 0)
            {
                customersComboBox.SelectedIndex = 0;
            }
            customersComboBox.EndUpdate();
        }

        /// <summary>
        /// Обновляет список товаров в корзине.
        /// </summary>
        private void UpdateCartListBox()
        {
            if (!_isInitialized) return;

            cartListBox.BeginUpdate();
            cartListBox.Items.Clear();

            if (_currentCustomer != null && _currentCustomer.Cart != null && _currentCustomer.Cart.Items != null)
            {
                foreach (var item in _currentCustomer.Cart.Items)
                {
                    cartListBox.Items.Add($"{item.Name} - {item.Cost:C}");
                }
            }

            cartListBox.EndUpdate();
            UpdateAmountLabels();
        }

        /// <summary>
        /// Обновляет суммы и доступность кнопок.
        /// </summary>
        private void UpdateAmountLabels()
        {
            if (!_isInitialized) return;

            if (_currentCustomer != null && _currentCustomer.Cart != null)
            {
                amountLabel.Text = _currentCustomer.Cart.Amount.ToString("F2");
                CalculateDiscounts();
                createOrderButton.Enabled = _currentCustomer.Cart.Items.Count > 0;
            }
            else
            {
                amountLabel.Text = "0,00";
                discountAmountLabel.Text = "0,00";
                totalLabel.Text = "0,00";
                createOrderButton.Enabled = false;
            }
        }

        /// <summary>
        /// Вычисляет скидки для текущей корзины.
        /// </summary>
        private void CalculateDiscounts()
        {
            if (!_isInitialized) return;
            if (_currentCustomer == null || _currentCustomer.Cart == null || _currentCustomer.Cart.Items == null)
            {
                discountAmountLabel.Text = "0,00";
                totalLabel.Text = "0,00";
                return;
            }

            decimal totalDiscount = 0;

            for (int i = 0; i < discountsCheckedListBox.Items.Count; i++)
            {
                if (discountsCheckedListBox.GetItemChecked(i))
                {
                    if (discountsCheckedListBox.Items[i] is IDiscount discount)
                    {
                        totalDiscount += discount.Calculate(_currentCustomer.Cart.Items);
                    }
                }
            }

            decimal cartAmount = _currentCustomer.Cart.Amount;
            discountAmountLabel.Text = totalDiscount.ToString("F2");
            totalLabel.Text = (cartAmount - totalDiscount).ToString("F2");
        }

        /// <summary>
        /// Обновляет список скидок в CheckedListBox.
        /// </summary>
        private void UpdateDiscountsListBox()
        {
            if (!_isInitialized) return;

            discountsCheckedListBox.BeginUpdate();
            discountsCheckedListBox.Items.Clear();

            if (_currentCustomer != null && _currentCustomer.Discounts != null)
            {
                foreach (var discount in _currentCustomer.Discounts)
                {
                    discountsCheckedListBox.Items.Add(discount, true);
                }
            }

            discountsCheckedListBox.EndUpdate();
            CalculateDiscounts();
        }

        #region Обработчики событий элементов управления

        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_isInitialized) return;
            if (customersComboBox.SelectedIndex >= 0 && customersComboBox.SelectedIndex < _customers.Count)
            {
                _currentCustomer = _customers[customersComboBox.SelectedIndex];
                priorityCheckBox.Checked = _currentCustomer.IsPriority;
                UpdateCartListBox();
                UpdateDiscountsListBox();
            }
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (!_isInitialized || _currentCustomer == null || itemsListBox.SelectedIndex < 0) return;

            int selectedIndex = itemsListBox.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < _items.Count)
            {
                var itemToAdd = _items[selectedIndex];
                _currentCustomer.Cart.Items.Add(itemToAdd);
                UpdateCartListBox();
            }
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (!_isInitialized || _currentCustomer == null || cartListBox.SelectedIndex < 0) return;

            int selectedIndex = cartListBox.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < _currentCustomer.Cart.Items.Count)
            {
                _currentCustomer.Cart.Items.RemoveAt(selectedIndex);
                UpdateCartListBox();
            }
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (!_isInitialized || _currentCustomer == null) return;

            var result = MessageBox.Show("Очистить корзину?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _currentCustomer.Cart.Items.Clear();
                UpdateCartListBox();
            }
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (!_isInitialized || _currentCustomer == null ||
                _currentCustomer.Cart == null || _currentCustomer.Cart.Items.Count == 0)
            {
                MessageBox.Show("Корзина пуста!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Order order;

                if (_currentCustomer.IsPriority)
                {
                    order = new PriorityOrder
                    {
                        Items = new List<Item>(_currentCustomer.Cart.Items.Select(item => (Item)item.Clone())),
                        Address = (Address)_currentCustomer.Address.Clone(),
                        Status = OrderStatus.New,
                        DiscountAmount = 0,
                        DesiredDeliveryDate = DateTime.Now.AddDays(1),
                        DeliveryTime = DeliveryTime.NineToEleven
                    };
                }
                else
                {
                    order = new Order
                    {
                        Items = new List<Item>(_currentCustomer.Cart.Items.Select(item => (Item)item.Clone())),
                        Address = (Address)_currentCustomer.Address.Clone(),
                        Status = OrderStatus.New,
                        DiscountAmount = 0
                    };
                }

                decimal totalDiscount = 0;

                for (int i = 0; i < discountsCheckedListBox.Items.Count; i++)
                {
                    if (discountsCheckedListBox.GetItemChecked(i))
                    {
                        if (discountsCheckedListBox.Items[i] is IDiscount discount)
                        {
                            totalDiscount += discount.Apply(order.Items);
                        }
                    }
                }
                order.DiscountAmount = totalDiscount;

                foreach (var discount in _currentCustomer.Discounts)
                {
                    discount.Update(order.Items);
                }

                _currentCustomer.Orders.Add(order);

                _currentCustomer.Cart.Items.Clear();
                UpdateCartListBox();
                UpdateDiscountsListBox();

                OrderCreated?.Invoke(this, EventArgs.Empty);

                MessageBox.Show("Заказ успешно создан!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании заказа: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DiscountsCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!_isInitialized) return;

            this.BeginInvoke(new Action(() => CalculateDiscounts()));
        }

        private void PriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            priorityCheckBox.Enabled = false;
        }

        #endregion
    }
}