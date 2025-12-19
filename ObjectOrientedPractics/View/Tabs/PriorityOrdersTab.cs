using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Вкладка для работы с приоритетными заказами.
    /// </summary>
    public partial class PriorityOrdersTab : UserControl
    {
        private PriorityOrder _currentOrder = null;

        /// <summary>
        /// Создает новую вкладку приоритетных заказов.
        /// </summary>
        public PriorityOrdersTab()
        {
            InitializeComponent();
            InitializeComboBoxes();
            InitializePriorityOrder();
        }

        /// <summary>
        /// Инициализирует выпадающие списки.
        /// </summary>
        private void InitializeComboBoxes()
        {
            statusComboBox.Items.Clear();
            foreach (OrderStatus status in Enum.GetValues(typeof(OrderStatus)))
            {
                statusComboBox.Items.Add(status);
            }

            deliveryTimeComboBox.Items.Clear();
            deliveryTimeComboBox.Items.Add("None");
            deliveryTimeComboBox.Items.Add("9:00 - 11:00");
            deliveryTimeComboBox.Items.Add("11:00 - 13:00");
            deliveryTimeComboBox.Items.Add("13:00 - 15:00");
            deliveryTimeComboBox.Items.Add("15:00 - 17:00");
            deliveryTimeComboBox.Items.Add("17:00 - 19:00");
            deliveryTimeComboBox.Items.Add("19:00 - 21:00");
        }

        /// <summary>
        /// Инициализирует приоритетный заказ.
        /// </summary>
        private void InitializePriorityOrder()
        {
            _currentOrder = new PriorityOrder();
            UpdateOrderFields();
        }

        /// <summary>
        /// Обновляет поля ввода данными текущего заказа.
        /// </summary>
        private void UpdateOrderFields()
        {
            if (_currentOrder == null) return;

            idTextBox.Text = _currentOrder.Id.ToString();
            createdTextBox.Text = _currentOrder.Date.ToString("dd.MM.yyyy HH:mm");

            if (statusComboBox.Items.Count > 0)
            {
                for (int i = 0; i < statusComboBox.Items.Count; i++)
                {
                    if (statusComboBox.Items[i].ToString() == _currentOrder.Status.ToString())
                    {
                        statusComboBox.SelectedIndex = i;
                        break;
                    }
                }
            }

            if (deliveryTimeComboBox.Items.Count > 0)
            {
                int index = (int)_currentOrder.DeliveryTime;
                if (index >= 0 && index < deliveryTimeComboBox.Items.Count)
                {
                    deliveryTimeComboBox.SelectedIndex = index;
                }
                else
                {
                    deliveryTimeComboBox.SelectedIndex = 0;
                }
            }

            addressControl.Address = _currentOrder.Address;
            UpdateOrderItemsListBox();
            amountLabel.Text = _currentOrder.Amount.ToString("F2");
        }

        /// <summary>
        /// Обновляет список товаров в заказе.
        /// </summary>
        private void UpdateOrderItemsListBox()
        {
            orderItemsListBox.Items.Clear();
            if (_currentOrder.Items != null)
            {
                foreach (var item in _currentOrder.Items)
                {
                    orderItemsListBox.Items.Add($"{item.Name} - {item.Cost:C}");
                }
            }
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if (_currentOrder.Items == null)
            {
                _currentOrder.Items = new List<Item>();
            }

            var randomItem = new Item(
                $"Товар {new Random().Next(1000, 9999)}",
                $"Описание товара",
                new Random().Next(100, 10000),
                Category.Other
            );

            _currentOrder.Items.Add(randomItem);
            UpdateOrderFields();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (_currentOrder.Items == null || orderItemsListBox.SelectedIndex < 0) return;

            int selectedIndex = orderItemsListBox.SelectedIndex;
            _currentOrder.Items.RemoveAt(selectedIndex);

            UpdateOrderItemsListBox();

            if (orderItemsListBox.Items.Count > 0)
            {
                if (selectedIndex < orderItemsListBox.Items.Count)
                {
                    orderItemsListBox.SelectedIndex = selectedIndex;
                }
                else
                {
                    orderItemsListBox.SelectedIndex = orderItemsListBox.Items.Count - 1;
                }
            }

            amountLabel.Text = _currentOrder.Amount.ToString("F2");
        }

        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            _currentOrder = new PriorityOrder();
            UpdateOrderFields();
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentOrder != null && statusComboBox.SelectedIndex != -1)
            {
                _currentOrder.Status = (OrderStatus)statusComboBox.SelectedItem;
            }
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentOrder != null && deliveryTimeComboBox.SelectedIndex != -1)
            {
                _currentOrder.DeliveryTime = (DeliveryTime)deliveryTimeComboBox.SelectedIndex;
            }
        }

        private void AddressControl_AddressChanged(object sender, EventArgs e)
        {
            if (_currentOrder != null && addressControl != null)
            {
                _currentOrder.Address = addressControl.Address;
            }
        }
    }
}