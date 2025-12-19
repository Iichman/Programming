using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Вкладка для работы с товарами.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        private List<Item> _items = new List<Item>();
        private List<Item> _displayedItems = new List<Item>();
        private Item _currentItem;
        private bool _isUpdating = false;

        /// <summary>
        /// Событие изменения товаров.
        /// </summary>
        public event EventHandler ItemsChanged;

        /// <summary>
        /// Создает новый экземпляр класса <see cref="ItemsTab"/>.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            InitializeAdditionalControls();
            LoadSampleData();
        }

        /// <summary>
        /// Инициализирует дополнительные элементы управления.
        /// </summary>
        private void InitializeAdditionalControls()
        {
            categoryComboBox.DataSource = Enum.GetValues(typeof(Category));

            sortComboBox.Items.AddRange(new string[] { "По цене (возр.)", "По цене (убыв.)" });
            sortComboBox.SelectedIndex = 0;

            itemsListBox.SelectionMode = SelectionMode.One;

            removeButton.Enabled = false;

            UpdateDisplayedItems();
        }

        /// <summary>
        /// Загружает тестовые данные.
        /// </summary>
        private void LoadSampleData()
        {
            try
            {
                _items.Add(new Item("Ноутбук", "Игровой ноутбук", 85000, Category.Electronics));
                _items.Add(new Item("Смартфон", "Флагманский смартфон", 65000, Category.Electronics));
                _items.Add(new Item("Книга", "Программирование на C#", 1500, Category.Books));
                _items.Add(new Item("Футболка", "Хлопковая футболка", 1200, Category.Clothing));
                _items.Add(new Item("Кофе", "Арабика 1 кг", 2500, Category.Food));
                _items.Add(new Item("Стул", "Офисный стул", 5000, Category.Furniture));

                UpdateDisplayedItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке тестовых данных: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Обновляет отображаемые товары с учетом фильтрации и сортировки.
        /// </summary>
        private void UpdateDisplayedItems()
        {
            if (_isUpdating) return;
            _isUpdating = true;

            try
            {
                string searchText = searchTextBox.Text.Trim();
                List<Item> filteredItems;

                if (!string.IsNullOrEmpty(searchText))
                {
                    filteredItems = _items.FindAll(item =>
                        item.Name.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        item.Info.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0);
                }
                else
                {
                    filteredItems = new List<Item>(_items);
                }

                switch (sortComboBox.SelectedIndex)
                {
                    case 0: 
                        filteredItems.Sort((x, y) => string.Compare(x.Name, y.Name, StringComparison.Ordinal));
                        break;
                    case 1: 
                        filteredItems.Sort((x, y) => x.Cost.CompareTo(y.Cost));
                        break;
                    case 2: 
                        filteredItems.Sort((x, y) => y.Cost.CompareTo(x.Cost));
                        break;
                }

                _displayedItems = filteredItems;
                UpdateListBox();
            }
            finally
            {
                _isUpdating = false;
            }
        }

        /// <summary>
        /// Обновляет ListBox с товарами.
        /// </summary>
        private void UpdateListBox()
        {
            itemsListBox.BeginUpdate();
            itemsListBox.Items.Clear();

            foreach (var item in _displayedItems)
            {
                itemsListBox.Items.Add($"{item.Id}: {item.Name} - {item.Cost:C}");
            }

            if (_currentItem != null)
            {
                int index = _displayedItems.IndexOf(_currentItem);
                if (index != -1)
                {
                    itemsListBox.SelectedIndex = index;
                }
                else
                {
                    _currentItem = null;
                    ClearFields();
                }
            }

            itemsListBox.EndUpdate();
        }

        /// <summary>
        /// Очищает поля ввода информации о товаре.
        /// </summary>
        private void ClearFields()
        {
            idTextBox.Clear();
            costTextBox.Clear();
            nameTextBox.Clear();
            descriptionTextBox.Clear();
            categoryComboBox.SelectedIndex = 0;

            costTextBox.BackColor = Color.White;
            nameTextBox.BackColor = Color.White;
            descriptionTextBox.BackColor = Color.White;

            removeButton.Enabled = false;
        }

        /// <summary>
        /// Отображает информацию о выбранном товаре в полях ввода.
        /// </summary>
        private void ShowItemInfo()
        {
            if (_currentItem != null)
            {
                idTextBox.Text = _currentItem.Id.ToString();
                costTextBox.Text = _currentItem.Cost.ToString("F2");
                nameTextBox.Text = _currentItem.Name;
                descriptionTextBox.Text = _currentItem.Info;
                categoryComboBox.SelectedItem = _currentItem.Category;

                costTextBox.BackColor = Color.White;
                nameTextBox.BackColor = Color.White;
                descriptionTextBox.BackColor = Color.White;

                removeButton.Enabled = true;
            }
        }

        /// <summary>
        /// Вызывает событие <see cref="ItemsChanged"/>.
        /// </summary>
        protected virtual void OnItemsChanged()
        {
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        #region Обработчики событий элементов управления

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateDisplayedItems();
        }

        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDisplayedItems();
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex == -1)
            {
                _currentItem = null;
                ClearFields();
                return;
            }

            int selectedIndex = itemsListBox.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < _displayedItems.Count)
            {
                _currentItem = _displayedItems[selectedIndex];
                ShowItemInfo();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nameTextBox.Text))
                {
                    MessageBox.Show("Введите название товара", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nameTextBox.Focus();
                    nameTextBox.BackColor = Color.LightPink;
                    return;
                }

                if (!decimal.TryParse(costTextBox.Text, out decimal cost))
                {
                    MessageBox.Show("Введите корректную стоимость", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    costTextBox.Focus();
                    costTextBox.BackColor = Color.LightPink;
                    return;
                }

                if (cost < 0 || cost > 100000)
                {
                    MessageBox.Show("Стоимость должна быть от 0 до 100 000", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    costTextBox.Focus();
                    costTextBox.BackColor = Color.LightPink;
                    return;
                }

                if (categoryComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Выберите категорию", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    ValueValidator.AssertStringOnLength(nameTextBox.Text.Trim(), 200, "Название");
                    nameTextBox.BackColor = Color.White;
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show($"Ошибка в названии: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nameTextBox.Focus();
                    nameTextBox.BackColor = Color.LightPink;
                    return;
                }

                try
                {
                    ValueValidator.AssertStringOnLength(descriptionTextBox.Text.Trim(), 1000, "Описание");
                    descriptionTextBox.BackColor = Color.White;
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show($"Ошибка в описании: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    descriptionTextBox.Focus();
                    descriptionTextBox.BackColor = Color.LightPink;
                    return;
                }

                Category category = (Category)categoryComboBox.SelectedItem;

                Item newItem = new Item(
                    nameTextBox.Text.Trim(),
                    descriptionTextBox.Text.Trim(),
                    cost,
                    category
                );

                _items.Add(newItem);
                UpdateDisplayedItems();
                ClearFields();
                OnItemsChanged();

                MessageBox.Show("Товар успешно добавлен!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Ошибка валидации: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (_currentItem == null)
            {
                MessageBox.Show("Выберите товар для удаления", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show($"Удалить товар '{_currentItem.Name}'?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _items.Remove(_currentItem);
                UpdateDisplayedItems();
                ClearFields();
                _currentItem = null;
                OnItemsChanged();

                MessageBox.Show("Товар удален", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentItem != null && !_isUpdating)
            {
                try
                {
                    _currentItem.Name = nameTextBox.Text;
                    nameTextBox.BackColor = Color.White;
                    UpdateListBox();
                    OnItemsChanged();
                }
                catch (ArgumentException)
                {
                    nameTextBox.BackColor = Color.LightPink;
                }
            }
        }

        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            if (_currentItem != null && !_isUpdating)
            {
                try
                {
                    ValueValidator.AssertStringOnLength(nameTextBox.Text, 200, "Название");
                    nameTextBox.BackColor = Color.White;
                }
                catch (ArgumentException)
                {
                    nameTextBox.BackColor = Color.LightPink;
                }
            }
            else if (!_isUpdating && !string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                try
                {
                    ValueValidator.AssertStringOnLength(nameTextBox.Text, 200, "Название");
                    nameTextBox.BackColor = Color.White;
                }
                catch (ArgumentException)
                {
                    nameTextBox.BackColor = Color.LightPink;
                }
            }
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentItem != null && !_isUpdating)
            {
                try
                {
                    if (decimal.TryParse(costTextBox.Text, out decimal cost))
                    {
                        _currentItem.Cost = cost;
                        costTextBox.BackColor = Color.White;
                        UpdateListBox();
                        OnItemsChanged();
                    }
                    else if (!string.IsNullOrWhiteSpace(costTextBox.Text))
                    {
                        costTextBox.BackColor = Color.LightPink;
                    }
                }
                catch (ArgumentException)
                {
                    costTextBox.BackColor = Color.LightPink;
                }
            }
        }

        private void CostTextBox_Leave(object sender, EventArgs e)
        {
            if (_currentItem != null && !_isUpdating)
            {
                try
                {
                    if (decimal.TryParse(costTextBox.Text, out decimal cost))
                    {
                        ValueValidator.AssertValueInRange(cost, 0, 100000, "Стоимость");
                        costTextBox.BackColor = Color.White;
                    }
                    else if (!string.IsNullOrWhiteSpace(costTextBox.Text))
                    {
                        costTextBox.BackColor = Color.LightPink;
                    }
                }
                catch (ArgumentException)
                {
                    costTextBox.BackColor = Color.LightPink;
                }
            }
            else if (!_isUpdating && !string.IsNullOrWhiteSpace(costTextBox.Text))
            {
                try
                {
                    if (decimal.TryParse(costTextBox.Text, out decimal cost))
                    {
                        ValueValidator.AssertValueInRange(cost, 0, 100000, "Стоимость");
                        costTextBox.BackColor = Color.White;
                    }
                    else
                    {
                        costTextBox.BackColor = Color.LightPink;
                    }
                }
                catch (ArgumentException)
                {
                    costTextBox.BackColor = Color.LightPink;
                }
            }
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentItem != null && !_isUpdating)
            {
                try
                {
                    _currentItem.Info = descriptionTextBox.Text;
                    descriptionTextBox.BackColor = Color.White;
                    OnItemsChanged();
                }
                catch (ArgumentException)
                {
                    descriptionTextBox.BackColor = Color.LightPink;
                }
            }
        }

        private void DescriptionTextBox_Leave(object sender, EventArgs e)
        {
            if (_currentItem != null && !_isUpdating)
            {
                try
                {
                    ValueValidator.AssertStringOnLength(descriptionTextBox.Text, 1000, "Описание");
                    descriptionTextBox.BackColor = Color.White;
                }
                catch (ArgumentException)
                {
                    descriptionTextBox.BackColor = Color.LightPink;
                }
            }
            else if (!_isUpdating && !string.IsNullOrWhiteSpace(descriptionTextBox.Text))
            {
                try
                {
                    ValueValidator.AssertStringOnLength(descriptionTextBox.Text, 1000, "Описание");
                    descriptionTextBox.BackColor = Color.White;
                }
                catch (ArgumentException)
                {
                    descriptionTextBox.BackColor = Color.LightPink;
                }
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentItem != null && categoryComboBox.SelectedItem != null && !_isUpdating)
            {
                _currentItem.Category = (Category)categoryComboBox.SelectedItem;
                UpdateListBox();
                OnItemsChanged();
            }
        }

        #endregion

        /// <summary>
        /// Обновляет данные на вкладке.
        /// </summary>
        public void RefreshData()
        {
            UpdateDisplayedItems();
        }

        /// <summary>
        /// Список товаров.
        /// </summary>
        public List<Item> Items
        {
            get => _items;
            set
            {
                _items = value ?? new List<Item>();
                UpdateDisplayedItems();
            }
        }
    }
}