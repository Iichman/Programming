using System;
using System.Drawing;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Элемент управления для ввода и отображения адреса.
    /// </summary>
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Адрес, отображаемый в элементе управления.
        /// </summary>
        private Address _address = new Address();

        /// <summary>
        /// Создает экземпляр класса <see cref="AddressControl"/>.
        /// </summary>
        public AddressControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Возвращает или задает адрес, отображаемый в элементе управления.
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set
            {
                _address = value ?? new Address();
                UpdateAddressFields();
            }
        }

        /// <summary>
        /// Обновляет поля ввода значениями из объекта адреса.
        /// </summary>
        private void UpdateAddressFields()
        {
            if (_address != null)
            {
                indexTextBox.Text = _address.Index.ToString();
                countryTextBox.Text = _address.Country;
                cityTextBox.Text = _address.City;
                streetTextBox.Text = _address.Street;
                buildingTextBox.Text = _address.Building;
                apartmentTextBox.Text = _address.Apartment;
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в поле индекса.
        /// </summary>
        private void IndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(indexTextBox.Text, out int index))
                {
                    _address.Index = index;
                    indexTextBox.BackColor = Color.White;
                }
                else if (string.IsNullOrEmpty(indexTextBox.Text))
                {
                    indexTextBox.BackColor = Color.White;
                }
                else
                {
                    indexTextBox.BackColor = Color.LightPink;
                }
            }
            catch (ArgumentException)
            {
                indexTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в поле страны.
        /// </summary>
        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Country = countryTextBox.Text;
                countryTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                countryTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в поле города.
        /// </summary>
        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.City = cityTextBox.Text;
                cityTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                cityTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в поле улицы.
        /// </summary>
        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Street = streetTextBox.Text;
                streetTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                streetTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в поле номера дома.
        /// </summary>
        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Building = buildingTextBox.Text;
                buildingTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                buildingTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в поля номера квартиры.
        /// </summary>
        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Apartment = apartmentTextBox.Text;
                apartmentTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                apartmentTextBox.BackColor = Color.LightPink;
            }
        }
    }
}