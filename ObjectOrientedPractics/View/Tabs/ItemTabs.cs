using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Tab для управления товарами.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Текущий выбранный товар.
        /// </summary>
        private Item? _currentItem;

        /// <summary>
        /// Создает экземпляр класса <see cref="ItemsTab"/>.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();

            // Инициализация ComboBox категорий
            categoryComboBox.DataSource = Enum.GetValues(typeof(Category));
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
                UpdateListBox();
            }
        }

        /// <summary>
        /// Генерирует следующий ID для товара.
        /// </summary>
        /// <returns>Следующий ID.</returns>
        private int GetNextId()
        {
            if (_items.Count == 0)
                return 1;

            int maxId = 0;
            foreach (var item in _items)
            {
                if (item.Id > maxId)
                    maxId = item.Id;
            }
            return maxId + 1;
        }

        /// <summary>
        /// Обновляет список товаров в ListBox.
        /// </summary>
        private void UpdateListBox()
        {
            itemsListBox.Items.Clear();

            foreach (var item in _items)
            {
                itemsListBox.Items.Add($"{item.Id}: {item.Name}");
            }
        }

        /// <summary>
        /// Очищает текстовые поля ввода.
        /// </summary>
        private void ClearFields()
        {
            idTextBox.Clear();
            costTextBox.Clear();
            nameTextBox.Clear();
            descriptionTextBox.Clear();
            categoryComboBox.SelectedIndex = 0; // Устанавливаем первый элемент вместо -1

            // Сбрасываем цвет фона
            costTextBox.BackColor = Color.White;
            nameTextBox.BackColor = Color.White;
            descriptionTextBox.BackColor = Color.White;
        }

        /// <summary>
        /// Отображает информацию о выбранном товаре.
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

                // Устанавливаем белый цвет при отображении
                costTextBox.BackColor = Color.White;
                nameTextBox.BackColor = Color.White;
                descriptionTextBox.BackColor = Color.White;
            }
            else
            {
                ClearFields();
            }
        }

        /// <summary>
        /// Обработчик события изменения выбранного элемента в списке товаров.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex == -1)
            {
                _currentItem = null;
                ClearFields();
                return;
            }

            _currentItem = _items[itemsListBox.SelectedIndex];
            ShowItemInfo();
        }

        /// <summary>
        /// Обработчик события нажатия кнопки добавления товара.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameTextBox.Text;
                string info = descriptionTextBox.Text;

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(info))
                {
                    MessageBox.Show("Please enter name and description");
                    return;
                }

                if (!double.TryParse(costTextBox.Text, out double cost) || cost < 0)
                {
                    MessageBox.Show("Please enter valid cost");
                    return;
                }

                // Исправлено: проверяем, что выбран элемент и он не NULL
                if (categoryComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select category");
                    return;
                }

                // Создаем товар с уникальным ID
                int nextId = GetNextId();
                Category category = (Category)categoryComboBox.SelectedItem; // Теперь безопасно
                Item newItem = new Item(nextId, name, info, cost, category);
                _items.Add(newItem);

                UpdateListBox();
                ClearFields();

                MessageBox.Show("Item added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        /// <summary>
        /// Обработчик события нажатия кнопки удаления товара.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select item to remove");
                return;
            }

            int index = itemsListBox.SelectedIndex;
            _items.RemoveAt(index);

            UpdateListBox();
            ClearFields();
            _currentItem = null;

            MessageBox.Show("Item removed!");
        }

        /// <summary>
        /// Обработчик события изменения текста в поле Name.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentItem != null)
            {
                try
                {
                    // Проверяем валидность имени
                    bool isValid = ValueValidator.ValidateStringLength(
                        nameTextBox.Text, 1000, "Name");

                    // Меняем цвет фона
                    nameTextBox.BackColor = isValid ? Color.White : Color.LightPink;

                    if (isValid)
                    {
                        _currentItem.Name = nameTextBox.Text;
                        UpdateListBox();
                    }
                }
                catch
                {
                    // Если ошибка - подсвечиваем красным
                    nameTextBox.BackColor = Color.LightPink;
                }
            }
            else
            {
                // Проверка при вводе нового элемента
                bool isValid = ValueValidator.ValidateStringLength(
                    nameTextBox.Text, 1000, "Name");
                nameTextBox.BackColor = isValid ? Color.White : Color.LightPink;
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в поле Cost.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentItem != null)
            {
                try
                {
                    if (double.TryParse(costTextBox.Text, out double cost))
                    {
                        bool isValid = ValueValidator.ValidateCostInRange(cost, 0, 100000, "Cost");
                        costTextBox.BackColor = isValid ? Color.White : Color.LightPink;

                        if (isValid)
                        {
                            _currentItem.Cost = cost;
                        }
                    }
                    else
                    {
                        costTextBox.BackColor = Color.LightPink;
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
                if (double.TryParse(costTextBox.Text, out double cost))
                {
                    bool isValid = ValueValidator.ValidateCostInRange(cost, 0, 100000, "Cost");
                    costTextBox.BackColor = isValid ? Color.White : Color.LightPink;
                }
                else if (string.IsNullOrEmpty(costTextBox.Text))
                {
                    costTextBox.BackColor = Color.White;
                }
                else
                {
                    costTextBox.BackColor = Color.LightPink;
                }
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в поле Description.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentItem != null)
            {
                try
                {
                    // Проверяем валидность описания
                    bool isValid = ValueValidator.ValidateStringLength(
                        descriptionTextBox.Text, 10000, "Description");

                    // Меняем цвет фона
                    descriptionTextBox.BackColor = isValid ? Color.White : Color.LightPink;

                    if (isValid)
                    {
                        _currentItem.Info = descriptionTextBox.Text;
                    }
                }
                catch
                {
                    // Если ошибка - подсвечиваем красным
                    descriptionTextBox.BackColor = Color.LightPink;
                }
            }
            else
            {
                // Проверка при вводе нового элемента
                bool isValid = ValueValidator.ValidateStringLength(
                    descriptionTextBox.Text, 10000, "Description");
                descriptionTextBox.BackColor = isValid ? Color.White : Color.LightPink;
            }
        }

        /// <summary>
        /// Обработчик события изменения выбранной категории.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentItem != null && categoryComboBox.SelectedItem != null)
            {
                _currentItem.Category = (Category)categoryComboBox.SelectedItem;
            }
        }
    }
}