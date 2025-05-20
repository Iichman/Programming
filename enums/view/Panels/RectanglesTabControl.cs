using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model;
using Programming.Model.Factories;
using Rectangle = Programming.Model.Rectangle;

namespace Programming.View.Controls
{
    /// <summary>
    /// Элемент управления для отображения и управления прямоугольниками.
    /// </summary>
    public partial class RectanglesControl : UserControl
    {
        private List<Rectangle> _rectangles = new List<Rectangle>();
        private List<Panel> _rectanglePanels = new List<Panel>();
        private Rectangle? _currentRectangle;

        /// <summary>
        /// Событие, которое возникает при изменении списка прямоугольников.
        /// </summary>
        public event EventHandler RectanglesChanged;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="RectanglesControl"/>.
        /// </summary>
        public RectanglesControl()
        {
            InitializeComponent();
            InitializeRectanglesTab();
        }

        /// <summary>
        /// Инициализирует элементы управления на вкладке прямоугольников.
        /// </summary>
        private void InitializeRectanglesTab()
        {
            rectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            addRectangleButton.Click += AddRectangleButton_Click;
            removeRectangleButton.Click += RemoveRectangleButton_Click;

            lengthTextBox.TextChanged += RectangleParameter_TextChanged;
            widthTextBox.TextChanged += RectangleParameter_TextChanged;
            centerXTextBox.TextChanged += RectangleParameter_TextChanged;
            centerYTextBox.TextChanged += RectangleParameter_TextChanged;
        }

        /// <summary>
        /// Находит все коллизии между прямоугольниками и обновляет их отображение.
        /// </summary>
        public void FindCollisions()
        {
            foreach (var panel in _rectanglePanels)
            {
                panel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
            }

            for (int i = 0; i < _rectangles.Count; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                        _rectanglePanels[j].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки добавления нового прямоугольника.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект события.</param>
        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            try
            {
                var rectangle = RectangleFactory.Randomize(canvasPanel.Width, canvasPanel.Height);
                _rectangles.Add(rectangle);
                UpdateRectanglesList();

                var panel = new Panel
                {
                    Width = (int)rectangle.Width,
                    Height = (int)rectangle.Length,
                    Location = new Point(
                        (int)(rectangle.Center.X - rectangle.Width / 2),
                        (int)(rectangle.Center.Y - rectangle.Length / 2)),
                    BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127),
                    Tag = rectangle
                };

                _rectanglePanels.Add(panel);
                canvasPanel.Controls.Add(panel);
                FindCollisions();
                RectanglesChanged?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding rectangle: {ex.Message}", "Error");
            }
        }

        /// <summary>
        /// Обновляет список прямоугольников в пользовательском интерфейсе.
        /// </summary>
        private void UpdateRectanglesList()
        {
            rectanglesListBox.Items.Clear();
            foreach (var rectangle in _rectangles)
            {
                rectanglesListBox.Items.Add($"Rectangle {_rectangles.IndexOf(rectangle) + 1} (W: {rectangle.Width:F1}, L: {rectangle.Length:F1})");
            }
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки удаления выбранного прямоугольника.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект события.</param>
        private void RemoveRectangleButton_Click(object sender, EventArgs e)
        {
            if (rectanglesListBox.SelectedIndex == -1) return;

            try
            {
                int index = rectanglesListBox.SelectedIndex;
                _rectangles.RemoveAt(index);
                canvasPanel.Controls.Remove(_rectanglePanels[index]);
                _rectanglePanels.RemoveAt(index);

                UpdateRectanglesList();
                FindCollisions();
                ClearRectangleInfo();
                RectanglesChanged?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing rectangle: {ex.Message}", "Error");
            }
        }

        /// <summary>
        /// Обрабатывает изменение выбранного прямоугольника в списке.
        /// Обновляет информацию в текстовых полях.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект события.</param>
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rectanglesListBox.SelectedIndex == -1)
            {
                _currentRectangle = null;
                ClearRectangleInfo();
                return;
            }

            try
            {
                _currentRectangle = _rectangles[rectanglesListBox.SelectedIndex];
                lengthTextBox.Text = _currentRectangle.Length.ToString("F1");
                widthTextBox.Text = _currentRectangle.Width.ToString("F1");
                idTextBox.Text = _currentRectangle.Id.ToString();
                centerXTextBox.Text = _currentRectangle.Center.X.ToString("F1");
                centerYTextBox.Text = _currentRectangle.Center.Y.ToString("F1");

                lengthTextBox.BackColor = System.Drawing.Color.White;
                widthTextBox.BackColor = System.Drawing.Color.White;
                centerXTextBox.BackColor = System.Drawing.Color.White;
                centerYTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading rectangle: {ex.Message}", "Error");
            }
        }

        /// <summary>
        /// Очищает информацию о текущем прямоугольнике из текстовых полей.
        /// </summary>
        private void ClearRectangleInfo()
        {
            lengthTextBox.Clear();
            widthTextBox.Clear();
            idTextBox.Clear();
            centerXTextBox.Clear();
            centerYTextBox.Clear();
        }

        /// <summary>
        /// Обрабатывает изменения значений в текстовых полях параметров прямоугольника.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект события.</param>
        private void RectangleParameter_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null || sender is not System.Windows.Forms.TextBox textBox)
                return;

            try
            {
                if (string.IsNullOrWhiteSpace(textBox.Text)) return;

                double value = double.Parse(textBox.Text);

                if (textBox == lengthTextBox)
                {
                    _currentRectangle.Length = Validator.AssertOnPositiveValue(value, "Length");
                }
                else if (textBox == widthTextBox)
                {
                    _currentRectangle.Width = Validator.AssertOnPositiveValue(value, "Width");
                }
                else if (textBox == centerXTextBox)
                {
                    _currentRectangle.Center.X = value;
                }
                else if (textBox == centerYTextBox)
                {
                    _currentRectangle.Center.Y = value;
                }

                textBox.BackColor = System.Drawing.Color.White;

                int index = _rectangles.IndexOf(_currentRectangle);
                if (index != -1)
                {
                    var panel = _rectanglePanels[index];
                    panel.Width = (int)_currentRectangle.Width;
                    panel.Height = (int)_currentRectangle.Length;
                    panel.Location = new Point(
                        (int)(_currentRectangle.Center.X - _currentRectangle.Width / 2),
                        (int)(_currentRectangle.Center.Y - _currentRectangle.Length / 2));

                    rectanglesListBox.Items[index] = $"Rectangle {index + 1} (W: {_currentRectangle.Width:F1}, L: {_currentRectangle.Length:F1})";
                    FindCollisions();
                    RectanglesChanged?.Invoke(this, EventArgs.Empty);
                }
            }
            catch (FormatException)
            {
                textBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (ArgumentException ex)
            {
                textBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show(ex.Message, "Validation Error");
            }
        }

        /// <summary>
        /// Возвращает список прямоугольников.
        /// </summary>
        /// <returns>Список прямоугольников.</returns>
        public List<Rectangle> GetRectangles()
        {
            return _rectangles;
        }
    }
}