using System;
using System.Windows.Forms;
using Programming.Model; // Убедитесь, что у вас есть это пространство имен

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private Programming.Model.Rectangle[] _rectangles; // Используем полное имя для класса Rectangle
        private Programming.Model.Rectangle _currentRectangle; // Используем полное имя для класса Rectangle

        public MainForm()
        {
            InitializeComponent();
            InitializeRectangles();
            SetupClassesTab();
        }

        private void InitializeRectangles()
        {
            Random random = new Random();
            _rectangles = new Programming.Model.Rectangle[5];

            for (int i = 0; i < _rectangles.Length; i++)
            {
                double length = random.NextDouble() * 10; // Генерация случайной длины
                double width = random.NextDouble() * 10; // Генерация случайной ширины
                _rectangles[i] = new Programming.Model.Rectangle(length, width, "Red"); // Присвоение цвета по умолчанию
            }
        }

        private void SetupClassesTab()
        {
            TabPage classesTabPage = new TabPage("Classes");
            TabControl tabControl = new TabControl();
            tabControl.TabPages.Add(classesTabPage);
            tabControl.Dock = DockStyle.Fill; // Заполнение области вкладки

            ListBox rectanglesListBox = new ListBox();
            rectanglesListBox.Dock = DockStyle.Left; // Привязываем к левой стороне
            rectanglesListBox.Width = 200;

            foreach (var rectangle in _rectangles)
            {
                rectanglesListBox.Items.Add($"Length: {rectangle.Length:F2}, Width: {rectangle.Width:F2}, Color: {rectangle.Color}");
            }

            rectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;

            // Текстовые поля
            lengthTextBox.Dock = DockStyle.Top;
            widthTextBox.Dock = DockStyle.Top;
            colorTextBox.Dock = DockStyle.Top;
            findButton.Dock = DockStyle.Top;

            findButton.Text = "Find Max Width";
            findButton.Click += FindButton_Click;

            classesTabPage.Controls.Add(rectanglesListBox);
            classesTabPage.Controls.Add(lengthTextBox);
            classesTabPage.Controls.Add(widthTextBox);
            classesTabPage.Controls.Add(colorTextBox);
            classesTabPage.Controls.Add(findButton);
            this.Controls.Add(tabControl);
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = sender as ListBox;
            if (listBox.SelectedIndex >= 0 && listBox.SelectedIndex < _rectangles.Length)
            {
                _currentRectangle = _rectangles[listBox.SelectedIndex];
                UpdateTextBoxes();
            }
        }

        private void UpdateTextBoxes()
        {
            if (_currentRectangle != null)
            {
                lengthTextBox.Text = _currentRectangle.Length.ToString();
                widthTextBox.Text = _currentRectangle.Width.ToString();
                colorTextBox.Text = _currentRectangle.Color;
            }
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            int maxWidthIndex = FindRectangleWithMaxWidth(_rectangles);
            if (maxWidthIndex >= 0)
            {
                // Выбираем элемент в списке прямоугольников
                // Здесь нужно также обновить список, чтобы он учитывал изменения, если они есть
            }
        }

        private int FindRectangleWithMaxWidth(Programming.Model.Rectangle[] rectangles)
        {
            double maxWidth = 0;
            int index = -1;

            for (int i = 0; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    index = i;
                }
            }

            return index;
        }

        private void lengthTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(lengthTextBox, (value) => _currentRectangle.Length = double.Parse(value));
        }

        private void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(widthTextBox, (value) => _currentRectangle.Width = double.Parse(value));
        }

        private void colorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
                _currentRectangle.Color = colorTextBox.Text;
        }

        private void ValidateInput(TextBox textBox, Action<string> setter)
        {
            try
            {
                setter(textBox.Text);
                textBox.BackColor = Color.White; // Если все хорошо, белый
            }
            catch (Exception)
            {
                textBox.BackColor = Color.LightPink; // Если ошибка, красный
            }
        }
    }
}