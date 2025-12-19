using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Вкладка для работы с покупателями.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        private List<Customer> _customers = new List<Customer>();
        private Customer _currentCustomer = null;
        private bool _isUpdating = false;

        /// <summary>
        /// Создает новый экземпляр класса <see cref="CustomersTab"/>.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
            InitializeCategoryComboBox();
            ConfigureControls();
        }

        /// <summary>
        /// Настраивает элементы управления.
        /// </summary>
        private void ConfigureControls()
        {
            customersListBox.SelectionMode = SelectionMode.One;

            removeButton.Enabled = false;
            addDiscountButton.Enabled = false;
            removeDiscountButton.Enabled = false;
        }

        /// <summary>
        /// Инициализирует выпадающий список категорий.
        /// </summary>
        private void InitializeCategoryComboBox()
        {
            categoryComboBox.Items.Clear();

            foreach (Category category in Enum.GetValues(typeof(Category)))
            {
                if (category != Category.None)
                {
                    categoryComboBox.Items.Add(category);
                }
            }
            categoryComboBox.SelectedIndex = 0;
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
                UpdateCustomersListBox();
            }
        }

        /// <summary>
        /// Обновляет список покупателей в ListBox.
        /// </summary>
        private void UpdateCustomersListBox()
        {
            customersListBox.BeginUpdate();
            customersListBox.Items.Clear();

            foreach (var customer in _customers)
            {
                customersListBox.Items.Add(customer.FullName);
            }

            customersListBox.EndUpdate();

            removeButton.Enabled = _customers.Count > 0;
        }

        /// <summary>
        /// Обновляет список скидок.
        /// </summary>
        private void UpdateDiscountsListBox()
        {
            discountsListBox.BeginUpdate();
            discountsListBox.Items.Clear();

            if (_currentCustomer != null && _currentCustomer.Discounts != null)
            {
                var pointsDiscount = _currentCustomer.Discounts.FirstOrDefault(d => d is PointsDiscount);
                if (pointsDiscount != null)
                {
                    discountsListBox.Items.Add(pointsDiscount.Info);
                }

                foreach (var discount in _currentCustomer.Discounts)
                {
                    if (discount is PercentDiscount)
                    {
                        discountsListBox.Items.Add(discount.Info);
                    }
                }
            }

            discountsListBox.EndUpdate();

            bool hasCustomer = _currentCustomer != null;
            addDiscountButton.Enabled = hasCustomer;
            removeDiscountButton.Enabled = hasCustomer && discountsListBox.Items.Count > 0;
        }

        /// <summary>
        /// Очищает поля ввода информации о покупателе.
        /// </summary>
        private void ClearCustomerFields()
        {
            idTextBox.Clear();
            fullNameTextBox.Clear();
            addressControl.Clear();
            isPriorityCheckBox.Checked = false;
            discountsListBox.Items.Clear();
            categoryComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Обновляет поля ввода данными текущего покупателя.
        /// </summary>
        private void UpdateCustomerFields()
        {
            if (_currentCustomer == null)
            {
                ClearCustomerFields();
                return;
            }

            _isUpdating = true;
            try
            {
                idTextBox.Text = _currentCustomer.Id.ToString();
                fullNameTextBox.Text = _currentCustomer.FullName;
                addressControl.Address = _currentCustomer.Address;
                isPriorityCheckBox.Checked = _currentCustomer.IsPriority;
                UpdateDiscountsListBox();
            }
            finally
            {
                _isUpdating = false;
            }
        }

        /// <summary>
        /// Проверяет валидность данных покупателя.
        /// </summary>
        /// <returns>true, если данные валидны; иначе false.</returns>
        private bool ValidateCustomerData()
        {
            if (string.IsNullOrWhiteSpace(fullNameTextBox.Text))
            {
                MessageBox.Show("Введите ФИО покупателя", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fullNameTextBox.Focus();
                return false;
            }

            if (!addressControl.ValidateAddress())
            {
                MessageBox.Show("Адрес содержит ошибки. Исправьте их перед сохранением.",
                    "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        #region Обработчики событий элементов управления

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isUpdating) return;

            if (customersListBox.SelectedIndex >= 0 && customersListBox.SelectedIndex < _customers.Count)
            {
                _currentCustomer = _customers[customersListBox.SelectedIndex];
                UpdateCustomerFields();
            }
            else
            {
                _currentCustomer = null;
                ClearCustomerFields();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateCustomerData())
                {
                    return;
                }

                var customer = new Customer();

                customer.FullName = fullNameTextBox.Text.Trim();

                if (!addressControl.ValidateAddress())
                {
                    MessageBox.Show("Адрес содержит ошибки. Исправьте их перед добавлением покупателя.",
                        "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                customer.Address = addressControl.Address;
                customer.IsPriority = isPriorityCheckBox.Checked;

                _customers.Add(customer);
                UpdateCustomersListBox();
                customersListBox.SelectedIndex = _customers.Count - 1;

                MessageBox.Show("Покупатель успешно добавлен!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении покупателя: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (customersListBox.SelectedIndex >= 0 && customersListBox.SelectedIndex < _customers.Count)
            {
                var customer = _customers[customersListBox.SelectedIndex];
                var result = MessageBox.Show($"Удалить покупателя '{customer.FullName}'?",
                    "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _customers.RemoveAt(customersListBox.SelectedIndex);
                    UpdateCustomersListBox();

                    if (_customers.Count > 0)
                    {
                        customersListBox.SelectedIndex = 0;
                    }
                    else
                    {
                        _currentCustomer = null;
                        ClearCustomerFields();
                    }

                    MessageBox.Show("Покупатель удален!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentCustomer != null && !_isUpdating)
            {
                try
                {
                    _isUpdating = true;
                    _currentCustomer.FullName = fullNameTextBox.Text;

                    int selectedIndex = customersListBox.SelectedIndex;
                    UpdateCustomersListBox();
                    if (selectedIndex >= 0 && selectedIndex < customersListBox.Items.Count)
                    {
                        customersListBox.SelectedIndex = selectedIndex;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка валидации",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    _isUpdating = false;
                }
            }
        }

        private void FullNameTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(fullNameTextBox.Text))
                {
                    ValueValidator.AssertStringOnLength(fullNameTextBox.Text, 200, "ФИО");
                    fullNameTextBox.BackColor = Color.White;
                }
            }
            catch (ArgumentException)
            {
                fullNameTextBox.BackColor = Color.LightPink;
            }
        }

        private void IsPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (_currentCustomer != null && !_isUpdating)
            {
                _currentCustomer.IsPriority = isPriorityCheckBox.Checked;
            }
        }

        private void AddressControl_AddressChanged(object sender, EventArgs e)
        {
            if (_currentCustomer != null && !_isUpdating)
            {
                if (addressControl.ValidateAddress())
                {
                    _currentCustomer.Address = addressControl.Address;
                }
            }
        }

        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null)
            {
                MessageBox.Show("Сначала выберите покупателя!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (categoryComboBox.SelectedIndex < 0)
                {
                    MessageBox.Show("Выберите категорию для скидки!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Category selectedCategory = (Category)categoryComboBox.SelectedItem;

                bool exists = _currentCustomer.Discounts
                    .OfType<PercentDiscount>()
                    .Any(d => d.Category == selectedCategory);

                if (exists)
                {
                    MessageBox.Show($"У покупателя уже есть скидка на категорию '{selectedCategory}'!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newDiscount = new PercentDiscount(selectedCategory);
                _currentCustomer.Discounts.Add(newDiscount);
                UpdateDiscountsListBox();

                MessageBox.Show($"Скидка на категорию '{selectedCategory}' добавлена!",
                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении скидки: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveDiscountButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null)
            {
                MessageBox.Show("Сначала выберите покупателя!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (discountsListBox.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите скидку для удаления!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int selectedIndex = discountsListBox.SelectedIndex;

                if (selectedIndex == 0 && _currentCustomer.Discounts.Count > 0 &&
                    _currentCustomer.Discounts[0] is PointsDiscount)
                {
                    MessageBox.Show("Накопительную скидку удалять нельзя!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int percentDiscountIndex = 0;
                for (int i = 0; i < _currentCustomer.Discounts.Count; i++)
                {
                    if (_currentCustomer.Discounts[i] is PercentDiscount)
                    {
                        if (percentDiscountIndex == (selectedIndex - 1)) 
                        {
                            var discount = _currentCustomer.Discounts[i];
                            var result = MessageBox.Show($"Удалить скидку: {discount.Info}?",
                                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                _currentCustomer.Discounts.RemoveAt(i);
                                UpdateDiscountsListBox();
                                MessageBox.Show("Скидка удалена!", "Успех",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            break;
                        }
                        percentDiscountIndex++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении скидки: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DiscountsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeDiscountButton.Enabled = discountsListBox.SelectedIndex >= 0;
        }

        #endregion
    }
}