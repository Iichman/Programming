using System;
using System.Windows.Forms;
using Programming.Model;

namespace Programming.View.Controls
{
    /// <summary>
    /// Контроль для отображения и редактирования колец.
    /// </summary>
    public partial class RingsControl : UserControl
    {
        private Ring[] _rings = new Ring[5]; // Массив колец
        private Ring? _currentRing; // Текущее кольцо
        private int _nextRingId = 1; // Следующий идентификатор кольца

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="RingsControl"/>.
        /// </summary>
        public RingsControl()
        {
            InitializeComponent();
            InitializeRings();
        }

        /// <summary>
        /// Инициализирует кольца с случайными значениями.
        /// </summary>
        private void InitializeRings()
        {
            Random random = new Random();
            for (int i = 0; i < _rings.Length; i++)
            {
                double outerRadius = random.Next(5, 15) + random.NextDouble();
                double innerRadius = random.Next(1, (int)outerRadius - 1) + random.NextDouble();
                var center = new Point2D(
                    random.Next(20, 100) + random.NextDouble(),
                    random.Next(20, 100) + random.NextDouble());

                _rings[i] = new Ring(
                    _nextRingId++,
                    outerRadius,
                    innerRadius,
                    center);

                ringsListBox.Items.Add($"Ring {i + 1}");
            }
            ringsListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Обработчик события изменения выбранного индекса в списке колец.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void RingsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ringsListBox.SelectedIndex == -1) return;

            try
            {
                _currentRing = _rings[ringsListBox.SelectedIndex];
                outerRadiusTextBox.Text = _currentRing.OuterRadius.ToString("F1");
                innerRadiusTextBox.Text = _currentRing.InnerRadius.ToString("F1");
                ringCenterXTextBox.Text = _currentRing.Center.X.ToString("F1");
                ringCenterYTextBox.Text = _currentRing.Center.Y.ToString("F1");
                ringIdTextBox.Text = _currentRing.Id.ToString();

                outerRadiusTextBox.BackColor = System.Drawing.Color.White;
                innerRadiusTextBox.BackColor = System.Drawing.Color.White;
                ringCenterXTextBox.BackColor = System.Drawing.Color.White;
                ringCenterYTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading ring: {ex.Message}", "Error");
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в текстовых полях.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void RingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRing == null) return;

            var textBox = (TextBox)sender;
            try
            {
                if (string.IsNullOrWhiteSpace(textBox.Text)) return;

                if (sender == outerRadiusTextBox)
                {
                    _currentRing.OuterRadius = Validator.AssertOnPositiveValue(
                        double.Parse(outerRadiusTextBox.Text), "Outer Radius");
                }
                else if (sender == innerRadiusTextBox)
                {
                    double outerRadius = _currentRing.OuterRadius;
                    double innerRadius = double.Parse(innerRadiusTextBox.Text);
                    if (innerRadius >= outerRadius)
                    {
                        throw new ArgumentException("Inner radius must be less than outer radius");
                    }
                    _currentRing.InnerRadius = Validator.AssertOnPositiveValue(
                        innerRadius, "Inner Radius");
                }
                else if (sender == ringCenterXTextBox)
                {
                    _currentRing.Center.X = double.Parse(ringCenterXTextBox.Text);
                }
                else if (sender == ringCenterYTextBox)
                {
                    _currentRing.Center.Y = double.Parse(ringCenterYTextBox.Text);
                }

                textBox.BackColor = System.Drawing.Color.White;
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
        /// Обработчик события нажатия кнопки поиска кольца с максимальной площадью.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void FindRingButton_Click(object sender, EventArgs e)
        {
            if (_rings.Length == 0) return;

            try
            {
                Ring maxAreaRing = _rings[0];
                foreach (var ring in _rings)
                {
                    if (ring.Area > maxAreaRing.Area)
                    {
                        maxAreaRing = ring;
                    }
                }

                ringsListBox.SelectedIndex = Array.IndexOf(_rings, maxAreaRing);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error finding ring: {ex.Message}", "Error");
            }
        }

        /// <summary>
        /// Получает массив колец.
        /// </summary>
        /// <returns>Массив колец.</returns>
        public Ring[] GetRings()
        {
            return _rings;
        }
    }
}