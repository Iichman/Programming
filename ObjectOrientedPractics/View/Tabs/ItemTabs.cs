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
    /// Аргументы события изменения товаров.
    /// </summary>
    public class ItemsChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Тип изменения, произошедшего с товарами.
        /// </summary>
        public ItemChangeType ChangeType { get; }

        /// <summary>
        /// Измененный товар (если применимо).
        /// </summary>
        public Item ChangedItem { get; }

        /// <summary>
        /// Создает новый экземпляр <see cref="ItemsChangedEventArgs"/>.
        /// </summary>
        /// <param name="changeType">Тип изменения.</param>
        /// <param name="changedItem">Измененный товар.</param>
        public ItemsChangedEventArgs(ItemChangeType changeType, Item changedItem = null)
        {
            ChangeType = changeType;
            ChangedItem = changedItem;
        }
    }

    /// <summary>
    /// Тип изменения товаров.
    /// </summary>
    public enum ItemChangeType
    {
        /// <summary>
        /// Добавление нового товара.
        /// </summary>
        Added,

        /// <summary>
        /// Удаление товара.
        /// </summary>
        Removed,

        /// <summary>
        /// Редактирование товара.
        /// </summary>
        Edited,

        /// <summary>
        /// Несколько товаров изменены.
        /// </summary>
        MultipleChanged
    }

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
        public event EventHandler<ItemsChangedEventArgs> ItemsChanged;

        /// <summary>
        /// Создает новый экземпляр вкладки товаров.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            InitializeComboBoxes();
            LoadSampleData();
        }

        /// <summary>
        /// Инициализирует выпадающие списки.
        /// </summary>
        private void InitializeComboBoxes()
        {
            categoryComboBox.Items.Clear();
            foreach (Category category in Enum.GetValues(typeof(Category)))
            {
                categoryComboBox.Items.Add(category);
            }
            categoryComboBox.SelectedIndex = 0;

            sortComboBox.Items.Clear();
            sortComboBox.Items.AddRange(new object[]
            {
                "По имени (А-Я)",
                "По стоимости (возрастание)",
                "По стоимости (убывание)",
                "По категории (А-Я)"
            });
            sortComboBox.SelectedIndex = 0;
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
                _items.Add(new Item("Наушники", "Беспроводные наушники", 7500, Category.Electronics));
                _items.Add(new Item("Мышь", "Игровая мышь", 3000, Category.Electronics));

                UpdateDisplayedItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке тестовых данных: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Обновляет отображаемые товары.
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
                    filteredItems = DataTools.Filter(_items,
                        item => DataTools.FilterByNameContains(item, searchText));
                }
                else
                {
                    filteredItems = new List<Item>(_items);
                }

                if (filterAbove5000CheckBox.Checked)
                {
                    filteredItems = DataTools.Filter(filteredItems,
                        DataTools.FilterByPriceAbove5000);
                }

                switch (sortComboBox.SelectedIndex)
                {
                    case 0:
                        _displayedItems = DataTools.Sort(filteredItems, DataTools.CompareByName);
                        break;
                    case 1:
                        _displayedItems = DataTools.Sort(filteredItems, DataTools.CompareByCostAscending);
                        break;
                    case 2:
                        _displayedItems = DataTools.Sort(filteredItems, DataTools.CompareByCostDescending);
                        break;
                    case 3:
                        _displayedItems = DataTools.Sort(filteredItems, DataTools.CompareByCategory);
                        break;
                    default:
                        _displayedItems = filteredItems;
                        break;
                }

                UpdateListBox();
            }
            finally
            {
                _isUpdating = false;
            }
        }

        /// <summary>
        /// Обновляет список товаров.
        /// </summary>
        private void UpdateListBox()
        {
            itemsListBox.BeginUpdate();
            itemsListBox.Items.Clear();

            foreach (var item in _displayedItems)
            {
                itemsListBox.Items.Add($"{item.Name} - {item.Cost:C} ({item.Category})");
            }

            if (_currentItem != null)
            {
                int index = _displayedItems.FindIndex(item => item.Id == _currentItem.Id);
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
        /// Очищает поля ввода.
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
        /// Показывает информацию о выбранном товаре.
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
        /// Получает выбранный товар из списка.
        /// </summary>
        /// <returns>Выбранный товар или null.</returns>
        private Item GetSelectedItemFromListBox()
        {
            if (itemsListBox.SelectedIndex >= 0 && itemsListBox.SelectedIndex < _displayedItems.Count)
            {
                var displayedItem = _displayedItems[itemsListBox.SelectedIndex];
                return _items.Find(item => item.Id == displayedItem.Id);
            }
            return null;
        }

        /// <summary>
        /// Вызывает событие изменения товаров.
        /// </summary>
        /// <param name="changeType">Тип изменения.</param>
        /// <param name="changedItem">Измененный товар.</param>
        protected virtual void OnItemsChanged(ItemChangeType changeType, Item changedItem = null)
        {
            ItemsChanged?.Invoke(this, new ItemsChangedEventArgs(changeType, changedItem));
        }

        /// <summary>
        /// Обработчик изменения текста поиска.
        /// </summary>
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateDisplayedItems();
        }

        /// <summary>
        /// Обработчик изменения способа сортировки.
        /// </summary>
        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDisplayedItems();
        }

        /// <summary>
        /// Обработчик изменения фильтра по цене.
        /// </summary>
        private void FilterAbove5000CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDisplayedItems();
        }

        /// <summary>
        /// Обработчик изменения выбранного товара в списке.
        /// </summary>
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex == -1)
            {
                _currentItem = null;
                ClearFields();
                return;
            }

            _currentItem = GetSelectedItemFromListBox();
            if (_currentItem != null)
            {
                ShowItemInfo();
            }
            else
            {
                ClearFields();
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки добавления товара.
        /// </summary>
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
                OnItemsChanged(ItemChangeType.Added, newItem);

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

        /// <summary>
        /// Обработчик нажатия кнопки удаления товара.
        /// </summary>
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
                Item removedItem = _currentItem;
                _items.Remove(_currentItem);
                UpdateDisplayedItems();
                ClearFields();
                _currentItem = null;
                OnItemsChanged(ItemChangeType.Removed, removedItem);

                MessageBox.Show("Товар удален", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Обработчик изменения названия товара.
        /// </summary>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentItem != null && !_isUpdating)
            {
                try
                {
                    _currentItem.Name = nameTextBox.Text;
                    nameTextBox.BackColor = Color.White;
                    UpdateDisplayedItems();
                    OnItemsChanged(ItemChangeType.Edited, _currentItem);
                }
                catch (ArgumentException)
                {
                    nameTextBox.BackColor = Color.LightPink;
                }
            }
        }

        /// <summary>
        /// Обработчик изменения стоимости товара.
        /// </summary>
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
                        UpdateDisplayedItems();
                        OnItemsChanged(ItemChangeType.Edited, _currentItem);
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

        /// <summary>
        /// Обработчик изменения описания товара.
        /// </summary>
        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentItem != null && !_isUpdating)
            {
                try
                {
                    _currentItem.Info = descriptionTextBox.Text;
                    descriptionTextBox.BackColor = Color.White;
                    OnItemsChanged(ItemChangeType.Edited, _currentItem);
                }
                catch (ArgumentException)
                {
                    descriptionTextBox.BackColor = Color.LightPink;
                }
            }
        }

        /// <summary>
        /// Обработчик изменения категории товара.
        /// </summary>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentItem != null && categoryComboBox.SelectedItem != null && !_isUpdating)
            {
                _currentItem.Category = (Category)categoryComboBox.SelectedItem;
                UpdateDisplayedItems();
                OnItemsChanged(ItemChangeType.Edited, _currentItem);
            }
        }

        /// <summary>
        /// Обновляет данные на вкладке.
        /// </summary>
        public void RefreshData()
        {
            UpdateDisplayedItems();
        }

        /// <summary>
        /// Получает или задает список товаров.
        /// </summary>
        public List<Item> Items
        {
            get => _items;
            set
            {
                _items = value ?? new List<Item>();
                UpdateDisplayedItems();
                OnItemsChanged(ItemChangeType.MultipleChanged);
            }
        }
    }
}