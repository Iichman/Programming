using System;
using System.Windows.Forms;
using Programming.Model;

namespace Programming.View.Controls
{
    /// <summary>
    /// ������������� ������� ���������� � �������� ��� ������ � �������������� (enum).
    /// </summary>
    public partial class EnumsTabControl : UserControl
    {
        /// <summary>
        /// �������������� ����� ��������� ������ <see cref="EnumsTabControl"/>.
        /// </summary>
        public EnumsTabControl()
        {
            InitializeComponent();
            InitializeEnumsTab();
        }

        /// <summary>
        /// �������������� ������� ������������ � ��������� �������� ����������.
        /// </summary>
        private void InitializeEnumsTab()
        {
            enumsListBox.Items.AddRange(new[]
            {
                nameof(Weekday),
                nameof(Genre),
                "Color", // ���������� ������ ������ nameof(System.Drawing.Color)
                nameof(EducationForm),
                nameof(Manufacturer),
                nameof(Season)
            });

            enumsListBox.SelectedIndex = 0;

            seasonComboBox.DataSource = Enum.GetValues(typeof(Season));
            seasonComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// �������� ��� ������������ �� ��� �����.
        /// </summary>
        /// <param name="enumName">��� ������������.</param>
        /// <returns>��� ������������ ��� null, ���� ��� �� ������������� �� ������ �� ������������.</returns>
        private Type? GetEnumType(string? enumName)
        {
            if (string.IsNullOrEmpty(enumName)) return null;

            return enumName switch
            {
                "Weekday" => typeof(Weekday),
                "Genre" => typeof(Genre),
                "Color" => typeof(Color), 
                "EducationForm" => typeof(EducationForm),
                "Manufacturer" => typeof(Manufacturer),
                "Season" => typeof(Season),
                _ => null
            };
        }

        /// <summary>
        /// ������������ ��������� ���������� �������� � ������ ������������.
        /// </summary>
        private void EnumsListBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            valuesListBox.Items.Clear();
            indexListBox.Items.Clear();

            if (enumsListBox.SelectedItem is not string selectedEnum) return;

            try
            {
                Type? enumType = GetEnumType(selectedEnum);

                if (enumType != null && enumType.IsEnum)
                {
                    foreach (var value in Enum.GetNames(enumType))
                    {
                        valuesListBox.Items.Add(value);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading enum: {ex.Message}", "Error");
            }
        }

        /// <summary>
        /// ������������ ��������� ���������� �������� � ������ �������� ������������.
        /// </summary>
        private void ValuesListBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            indexListBox.Items.Clear();
            if (valuesListBox.SelectedItem is not string selectedValue ||
                enumsListBox.SelectedItem is not string selectedEnum) return;

            try
            {
                Type? enumType = GetEnumType(selectedEnum);

                if (enumType != null && enumType.IsEnum)
                {
                    var value = Enum.Parse(enumType, selectedValue);
                    indexListBox.Items.Add((int)value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting enum value: {ex.Message}", "Error");
            }
        }

        /// <summary>
        /// ������������ ������� ������ 'Parse'.
        /// </summary>
        private void ParseButton_Click(object? sender, EventArgs e)
        {
            if (enumsListBox.SelectedItem is not string selectedEnum ||
                !selectedEnum.Equals("Weekday") ||
                string.IsNullOrEmpty(parseInputTextBox.Text))
            {
                resultLabel.Text = "Please select Weekday and enter a value";
                resultLabel.BackColor = System.Drawing.Color.LightPink;
                return;
            }

            try
            {
                if (Enum.TryParse(typeof(Weekday), parseInputTextBox.Text, true, out var result))
                {
                    resultLabel.Text = $"��� ���� ������ ({result} = {(int)result})";
                    resultLabel.BackColor = System.Drawing.Color.LightGreen;
                }
                else
                {
                    resultLabel.Text = "��� ������ ��� ������";
                    resultLabel.BackColor = System.Drawing.Color.LightPink;
                }
            }
            catch (Exception ex)
            {
                resultLabel.Text = "Invalid value";
                resultLabel.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show($"Error parsing weekday: {ex.Message}", "Error");
            }
        }

        /// <summary>
        /// ������������ ������� ������ 'Go' ��� ��������� ������ ������.
        /// </summary>
        private void GoButton_Click(object? sender, EventArgs e)
        {
            if (seasonComboBox.SelectedItem == null) return;

            try
            {
                switch (seasonComboBox.SelectedItem.ToString())
                {
                    case "Summer":
                        MessageBox.Show("���! ������!", "Season");
                        break;
                    case "Autumn":
                        this.BackColor = System.Drawing.Color.FromArgb(226, 156, 69);
                        break;
                    case "Winter":
                        MessageBox.Show("����! �������!", "Season");
                        break;
                    case "Spring":
                        this.BackColor = System.Drawing.Color.FromArgb(85, 156, 69);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing season: {ex.Message}", "Error");
            }
        }
    }
}