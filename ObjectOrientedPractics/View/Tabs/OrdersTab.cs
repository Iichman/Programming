using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Вкладка для работы с заказами.
    /// </summary>
    public partial class OrdersTab : UserControl
    {
        private List<Customer> _customers;
        private List<Order> _allOrders;
        private Order _selectedOrder;
        private PriorityOrder _selectedPriorityOrder;
        private bool _isUpdating = false;

        private const string PrioritySymbol = "★";
        private const string NonPrioritySymbol = "";

        /// <summary>
        /// Создает новую вкладку заказов.
        /// </summary>
        public OrdersTab()
        {
            InitializeComponent();
            InitializeDataGridViewColumns();
            InitializeComboBoxes();
            SetupSorting();
        }

        /// <summary>
        /// Инициализирует колонки DataGridView.
        /// </summary>
        private void InitializeDataGridViewColumns()
        {
            ordersDataGridView.Columns.Clear();

            var priorityColumn = new DataGridViewTextBoxColumn
            {
                Name = "Priority",
                HeaderText = "Приоритет",
                Width = 80,
                SortMode = DataGridViewColumnSortMode.Automatic
            };
            ordersDataGridView.Columns.Add(priorityColumn);

            ordersDataGridView.Columns.Add("Id", "ID");
            ordersDataGridView.Columns["Id"].Width = 50;

            ordersDataGridView.Columns.Add("Date", "Дата создания");
            ordersDataGridView.Columns["Date"].Width = 100;

            ordersDataGridView.Columns.Add("Status", "Статус");
            ordersDataGridView.Columns["Status"].Width = 100;

            ordersDataGridView.Columns.Add("Total", "Общая сумма");
            ordersDataGridView.Columns["Total"].Width = 100;

            var typeColumn = new DataGridViewTextBoxColumn
            {
                Name = "Type",
                HeaderText = "Тип",
                Width = 80,
                Visible = false
            };
            ordersDataGridView.Columns.Add(typeColumn);

            ordersDataGridView.Columns["Priority"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            ordersDataGridView.CellFormatting += OrdersDataGridView_CellFormatting;
        }

        /// <summary>
        /// Настраивает сортировку.
        /// </summary>
        private void SetupSorting()
        {
            ordersDataGridView.SortCompare += OrdersDataGridView_SortCompare;
        }

        /// <summary>
        /// Настройка отображения ячеек (цвет звездочки приоритета).
        /// </summary>
        private void OrdersDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == ordersDataGridView.Columns["Priority"].Index && e.RowIndex >= 0)
            {
                if (e.Value?.ToString() == PrioritySymbol)
                {
                    e.CellStyle.ForeColor = Color.Gold;
                    e.CellStyle.Font = new Font(ordersDataGridView.Font, FontStyle.Bold);
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Gray;
                }
            }
        }

        /// <summary>
        /// Кастомная сортировка для колонки приоритета.
        /// </summary>
        private void OrdersDataGridView_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Name == "Priority")
            {
                string cell1 = e.CellValue1?.ToString() ?? "";
                string cell2 = e.CellValue2?.ToString() ?? "";

                bool isPriority1 = cell1 == PrioritySymbol;
                bool isPriority2 = cell2 == PrioritySymbol;

                if (isPriority1 && !isPriority2)
                {
                    e.SortResult = -1; 
                }
                else if (!isPriority1 && isPriority2)
                {
                    e.SortResult = 1; 
                }
                else
                {
                    e.SortResult = 0; 
                }

                e.Handled = true; 
            }
            else if (e.Column.Name == "Type")
            {
                
                e.SortResult = string.Compare(e.CellValue1?.ToString(), e.CellValue2?.ToString());
                e.Handled = true;
            }
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
        /// Список покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value ?? new List<Customer>();
                UpdateOrdersDataGridView();
            }
        }

        /// <summary>
        /// Обновляет DataGridView с заказами.
        /// </summary>
        private void UpdateOrdersDataGridView()
        {
            _allOrders = new List<Order>();
            foreach (var customer in _customers)
            {
                if (customer.Orders != null)
                {
                    _allOrders.AddRange(customer.Orders);
                }
            }

            ordersDataGridView.Rows.Clear();
            foreach (var order in _allOrders)
            {
                string orderType = order is PriorityOrder ? "Priority" : "Regular";
                string prioritySymbol = order is PriorityOrder ? PrioritySymbol : NonPrioritySymbol;

                ordersDataGridView.Rows.Add(
                    prioritySymbol,           
                    order.Id,                
                    order.Date.ToString("dd.MM.yyyy"), 
                    order.Status,            
                    order.Total.ToString("F2"), 
                    orderType                
                );
            }

            ordersDataGridView.Sort(ordersDataGridView.Columns["Priority"],
                System.ComponentModel.ListSortDirection.Descending);
        }

        /// <summary>
        /// Очищает поля ввода информации о заказе.
        /// </summary>
        private void ClearOrderDetails()
        {
            idTextBox.Clear();
            createdTextBox.Clear();
            statusComboBox.SelectedIndex = -1;
            addressControl.Clear();
            orderItemsListBox.Items.Clear();
            amountLabel.Text = "0,00";
            discountAmountLabel.Text = "0,00";
            totalLabel.Text = "0,00";
            deliveryTimeComboBox.Visible = false;
            deliveryTimeLabel.Visible = false;
        }

        /// <summary>
        /// Обновляет поля ввода данными выбранного заказа.
        /// </summary>
        private void UpdateOrderDetails()
        {
            if (_selectedOrder == null)
            {
                ClearOrderDetails();
                return;
            }

            try
            {
                _isUpdating = true;

                idTextBox.Text = _selectedOrder.Id.ToString();
                createdTextBox.Text = _selectedOrder.Date.ToString("dd.MM.yyyy HH:mm");

                statusComboBox.SelectedItem = _selectedOrder.Status;

                addressControl.Address = _selectedOrder.Address ?? new Address();

                orderItemsListBox.Items.Clear();
                if (_selectedOrder.Items != null && _selectedOrder.Items.Count > 0)
                {
                    foreach (var item in _selectedOrder.Items)
                    {
                        orderItemsListBox.Items.Add($"{item.Name} - {item.Cost:C}");
                    }
                }
                else
                {
                    orderItemsListBox.Items.Add("Товаров нет");
                }

                amountLabel.Text = _selectedOrder.Amount.ToString("F2");
                discountAmountLabel.Text = _selectedOrder.DiscountAmount.ToString("F2");
                totalLabel.Text = _selectedOrder.Total.ToString("F2");

                if (_selectedOrder is PriorityOrder priorityOrder)
                {
                    _selectedPriorityOrder = priorityOrder;
                    deliveryTimeComboBox.Visible = true;
                    deliveryTimeLabel.Visible = true;

                    int index = (int)priorityOrder.DeliveryTime;
                    if (index >= 0 && index < deliveryTimeComboBox.Items.Count)
                    {
                        deliveryTimeComboBox.SelectedIndex = index;
                    }
                    else
                    {
                        deliveryTimeComboBox.SelectedIndex = 0;
                    }
                }
                else
                {
                    _selectedPriorityOrder = null;
                    deliveryTimeComboBox.Visible = false;
                    deliveryTimeLabel.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении деталей заказа: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _isUpdating = false;
            }
        }

        /// <summary>
        /// Возвращает текстовое представление времени доставки.
        /// </summary>
        private string GetDeliveryTimeDisplayText(DeliveryTime deliveryTime)
        {
            switch (deliveryTime)
            {
                case DeliveryTime.NineToEleven: return "9:00 - 11:00";
                case DeliveryTime.ElevenToThirteen: return "11:00 - 13:00";
                case DeliveryTime.ThirteenToFifteen: return "13:00 - 15:00";
                case DeliveryTime.FifteenToSeventeen: return "15:00 - 17:00";
                case DeliveryTime.SeventeenToNineteen: return "17:00 - 19:00";
                case DeliveryTime.NineteenToTwentyOne: return "19:00 - 21:00";
                default: return "None";
            }
        }

        /// <summary>
        /// Обработчик клика по заголовку колонки для сортировки.
        /// </summary>
        private void OrdersDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (ordersDataGridView.Columns[e.ColumnIndex].Name == "Priority")
            {
                MessageBox.Show("Сортировка по приоритету: ★ - приоритетные заказы, пусто - обычные",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ordersDataGridView.SelectedRows.Count == 0) return;

            int selectedIndex = ordersDataGridView.SelectedRows[0].Index;
            if (selectedIndex >= 0 && selectedIndex < _allOrders.Count)
            {
                _selectedOrder = _allOrders[selectedIndex];
                UpdateOrderDetails();
            }
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_selectedOrder != null && !_isUpdating && statusComboBox.SelectedIndex != -1)
            {
                _selectedOrder.Status = (OrderStatus)statusComboBox.SelectedItem;
                UpdateOrdersDataGridView();
            }
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_selectedPriorityOrder != null && !_isUpdating && deliveryTimeComboBox.SelectedIndex != -1)
            {
                _selectedPriorityOrder.DeliveryTime = (DeliveryTime)deliveryTimeComboBox.SelectedIndex;
            }
        }

        private void AddressControl_AddressChanged(object sender, EventArgs e)
        {
            if (_selectedOrder != null && !_isUpdating)
            {
                _selectedOrder.Address = addressControl.Address;
            }
        }
    }
}