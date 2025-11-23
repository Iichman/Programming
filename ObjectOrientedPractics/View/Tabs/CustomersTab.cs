using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Controls;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Tab для управления покупателями.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Текущий выбранный покупатель.
        /// </summary>
        private Customer? _currentCustomer;

        /// <summary>
        /// Создает экземпляр класса <see cref="CustomersTab"/>.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
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
                UpdateListBox();
            }
        }

        /// <summary>
        /// Обновляет список покупателей в ListBox.
        /// </summary>
        private void UpdateListBox()
        {
            customersListBox.Items.Clear();

            foreach (var customer in _customers)
            {
                customersListBox.Items.Add($"{customer.Id}: {customer.Fullname}");
            }
        }

        /// <summary>
        /// Очищает текстовые поля ввода.
        /// </summary>
        private void ClearFields()
        {
            idTextBox.Clear();
            fullnameTextBox.Clear();
            addressControl.Address = new Address();

            // Сбрасываем цвет фона
            fullnameTextBox.BackColor = Color.White;
        }

        /// <summary>
        /// Отображает информацию о выбранном покупателе.
        /// </summary>
        private void ShowCustomerInfo()
        {
            if (_currentCustomer != null)
            {
                idTextBox.Text = _currentCustomer.Id.ToString();
                fullnameTextBox.Text = _currentCustomer.Fullname;
                addressControl.Address = _currentCustomer.Address;

                // Устанавливаем белый цвет при отображении
                fullnameTextBox.BackColor = Color.White;
            }
            else
            {
                ClearFields();
            }
        }

        /// <summary>
        /// Обработчик события изменения выбранного элемента в списке покупателей.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customersListBox.SelectedIndex == -1)
            {
                _currentCustomer = null;
                ClearFields();
                return;
            }

            _currentCustomer = _customers[customersListBox.SelectedIndex];
            ShowCustomerInfo();
        }

        /// <summary>
        /// Обработчик события нажатия кнопки добавления покупателя.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                string fullname = fullnameTextBox.Text;

                if (string.IsNullOrEmpty(fullname))
                {
                    MessageBox.Show("Please enter fullname");
                    return;
                }

                // Проверяем валидность имени
                bool isFullnameValid = ValueValidator.ValidateStringLength(fullname, 200, "Fullname");

                if (!isFullnameValid)
                {
                    MessageBox.Show("Please fix validation errors before adding customer.");
                    return;
                }

                // Создаем покупателя с уникальным ID из генератора
                Customer newCustomer = new Customer(fullname, addressControl.Address);
                _customers.Add(newCustomer);

                UpdateListBox();
                ClearFields();

                MessageBox.Show("Customer added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        /// <summary>
        /// Обработчик события нажатия кнопки удаления покупателя.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (customersListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select customer to remove");
                return;
            }

            int index = customersListBox.SelectedIndex;
            _customers.RemoveAt(index);

            UpdateListBox();
            ClearFields();
            _currentCustomer = null;

            MessageBox.Show("Customer removed!");
        }

        /// <summary>
        /// Обработчик события изменения текста в поле Fullname.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void FullnameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentCustomer != null)
            {
                try
                {
                    // Проверяем валидность
                    bool isValid = ValueValidator.ValidateStringLength(
                        fullnameTextBox.Text, 200, "Fullname");

                    // Меняем цвет фона
                    fullnameTextBox.BackColor = isValid ? Color.White : Color.LightPink;

                    if (isValid)
                    {
                        _currentCustomer.Fullname = fullnameTextBox.Text;
                        UpdateListBox();
                    }
                }
                catch
                {
                    // Если ошибка - ничего не делаем
                }
            }
            else
            {
                // Проверка при вводе нового элемента
                bool isValid = ValueValidator.ValidateStringLength(
                    fullnameTextBox.Text, 200, "Fullname");
                fullnameTextBox.BackColor = isValid ? Color.White : Color.LightPink;
            }
        }
    }
}