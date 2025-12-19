using System;
using System.Drawing;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Элемент управления для редактирования адреса.
    /// </summary>
    public partial class AddressControl : UserControl
    {
        private Address _address = new Address();
        private bool _isUpdatingFields = false;

        /// <summary>
        /// Событие изменения адреса.
        /// </summary>
        public event EventHandler AddressChanged;

        /// <summary>
        /// Создает новый экземпляр класса <see cref="AddressControl"/>.
        /// </summary>
        public AddressControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Адрес для редактирования.
        /// </summary>
        public Address Address
        {
            get => _address;
            set
            {
                if (_address != null)
                {
                    _address.AddressChanged -= Address_AddressChanged;
                }

                _address = value ?? new Address();

                _address.AddressChanged += Address_AddressChanged;

                UpdateFields();
                OnAddressChanged();
            }
        }

        /// <summary>
        /// Обработчик события изменения адреса.
        /// </summary>
        private void Address_AddressChanged(object sender, EventArgs e)
        {
            UpdateFields();
        }

        /// <summary>
        /// Вызывает событие <see cref="AddressChanged"/>.
        /// </summary>
        protected virtual void OnAddressChanged()
        {
            AddressChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Обновляет поля ввода данными из адреса.
        /// </summary>
        private void UpdateFields()
        {
            if (_address == null || _isUpdatingFields) return;

            _isUpdatingFields = true;
            try
            {
                postIndexTextBox.Text = _address.PostIndex;
                countryTextBox.Text = _address.Country;
                cityTextBox.Text = _address.City;
                streetTextBox.Text = _address.Street;
                buildingTextBox.Text = _address.Building;
                apartmentTextBox.Text = _address.Apartment;

                ClearErrorHighlights();
            }
            finally
            {
                _isUpdatingFields = false;
            }
        }

        /// <summary>
        /// Очищает все поля ввода.
        /// </summary>
        public void Clear()
        {
            postIndexTextBox.Clear();
            countryTextBox.Clear();
            cityTextBox.Clear();
            streetTextBox.Clear();
            buildingTextBox.Clear();
            apartmentTextBox.Clear();
            ClearErrorHighlights();
        }

        /// <summary>
        /// Очищает подсветку ошибок.
        /// </summary>
        private void ClearErrorHighlights()
        {
            postIndexTextBox.BackColor = Color.White;
            countryTextBox.BackColor = Color.White;
            cityTextBox.BackColor = Color.White;
            streetTextBox.BackColor = Color.White;
            buildingTextBox.BackColor = Color.White;
            apartmentTextBox.BackColor = Color.White;

            ClearErrors();
        }

        /// <summary>
        /// Очищает все сообщения об ошибках в ErrorProvider.
        /// </summary>
        private void ClearErrors()
        {
            postIndexErrorProvider.Clear();
            countryErrorProvider.Clear();
            cityErrorProvider.Clear();
            streetErrorProvider.Clear();
            buildingErrorProvider.Clear();
            apartmentErrorProvider.Clear();
        }

        /// <summary>
        /// Валидирует все поля адреса.
        /// </summary>
        /// <returns>true, если все поля валидны; иначе false.</returns>
        public bool ValidateAddress()
        {
            bool isValid = true;
            if (!ValidatePostIndex())
                isValid = false;

            if (!ValidateCountry())
                isValid = false;

            if (!ValidateCity())
                isValid = false;

            if (!ValidateStreet())
                isValid = false;

            if (!ValidateBuilding())
                isValid = false;

            if (!ValidateApartment())
                isValid = false;

            return isValid;
        }

        /// <summary>
        /// Валидирует почтовый индекс.
        /// </summary>
        /// <returns>true, если индекс валиден; иначе false.</returns>
        private bool ValidatePostIndex()
        {
            try
            {
                ValueValidator.AssertPostIndex(postIndexTextBox.Text, "Почтовый индекс");
                postIndexTextBox.BackColor = Color.White;
                postIndexErrorProvider.Clear();
                return true;
            }
            catch (ArgumentException ex)
            {
                postIndexTextBox.BackColor = Color.LightPink;
                postIndexErrorProvider.SetError(postIndexTextBox, ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Валидирует страну.
        /// </summary>
        /// <returns>true, если страна валидна; иначе false.</returns>
        private bool ValidateCountry()
        {
            try
            {
                ValueValidator.AssertStringNotNullOrEmpty(countryTextBox.Text, 50, "Страна");
                ValueValidator.AssertStringContainsOnlyLetters(countryTextBox.Text, "Страна");
                countryTextBox.BackColor = Color.White;
                countryErrorProvider.Clear();
                return true;
            }
            catch (ArgumentException ex)
            {
                countryTextBox.BackColor = Color.LightPink;
                countryErrorProvider.SetError(countryTextBox, ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Валидирует город.
        /// </summary>
        /// <returns>true, если город валиден; иначе false.</returns>
        private bool ValidateCity()
        {
            try
            {
                ValueValidator.AssertStringNotNullOrEmpty(cityTextBox.Text, 50, "Город");
                ValueValidator.AssertStringContainsOnlyLetters(cityTextBox.Text, "Город");
                cityTextBox.BackColor = Color.White;
                cityErrorProvider.Clear();
                return true;
            }
            catch (ArgumentException ex)
            {
                cityTextBox.BackColor = Color.LightPink;
                cityErrorProvider.SetError(cityTextBox, ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Валидирует улицу.
        /// </summary>
        /// <returns>true, если улица валидна; иначе false.</returns>
        private bool ValidateStreet()
        {
            try
            {
                ValueValidator.AssertStringNotNullOrEmpty(streetTextBox.Text, 100, "Улица");
                streetTextBox.BackColor = Color.White;
                streetErrorProvider.Clear();
                return true;
            }
            catch (ArgumentException ex)
            {
                streetTextBox.BackColor = Color.LightPink;
                streetErrorProvider.SetError(streetTextBox, ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Валидирует номер дома.
        /// </summary>
        /// <returns>true, если номер дома валиден; иначе false.</returns>
        private bool ValidateBuilding()
        {
            try
            {
                ValueValidator.AssertStringNotNullOrEmpty(buildingTextBox.Text, 10, "Номер дома");
                buildingTextBox.BackColor = Color.White;
                buildingErrorProvider.Clear();
                return true;
            }
            catch (ArgumentException ex)
            {
                buildingTextBox.BackColor = Color.LightPink;
                buildingErrorProvider.SetError(buildingTextBox, ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Валидирует номер квартиры.
        /// </summary>
        /// <returns>true, если номер квартиры валиден; иначе false.</returns>
        private bool ValidateApartment()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(apartmentTextBox.Text))
                {
                    ValueValidator.AssertStringOnLength(apartmentTextBox.Text, 10, "Номер квартиры");
                }
                apartmentTextBox.BackColor = Color.White;
                apartmentErrorProvider.Clear();
                return true;
            }
            catch (ArgumentException ex)
            {
                apartmentTextBox.BackColor = Color.LightPink;
                apartmentErrorProvider.SetError(apartmentTextBox, ex.Message);
                return false;
            }
        }

        #region Обработчики событий TextChanged

        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_address != null && !_isUpdatingFields)
            {
                // Валидируем при каждом изменении
                if (ValidatePostIndex())
                {
                    try
                    {
                        _address.PostIndex = postIndexTextBox.Text;
                        OnAddressChanged();
                    }
                    catch (ArgumentException)
                    {
                    }
                }
            }
        }

        private void PostIndexTextBox_Leave(object sender, EventArgs e)
        {
            ValidatePostIndex();
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_address != null && !_isUpdatingFields)
            {
                if (ValidateCountry())
                {
                    try
                    {
                        _address.Country = countryTextBox.Text;
                        OnAddressChanged();
                    }
                    catch (ArgumentException)
                    {
                    }
                }
            }
        }

        private void CountryTextBox_Leave(object sender, EventArgs e)
        {
            ValidateCountry();
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_address != null && !_isUpdatingFields)
            {
                if (ValidateCity())
                {
                    try
                    {
                        _address.City = cityTextBox.Text;
                        OnAddressChanged();
                    }
                    catch (ArgumentException)
                    {
                    }
                }
            }
        }

        private void CityTextBox_Leave(object sender, EventArgs e)
        {
            ValidateCity();
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_address != null && !_isUpdatingFields)
            {
                if (ValidateStreet())
                {
                    try
                    {
                        _address.Street = streetTextBox.Text;
                        OnAddressChanged();
                    }
                    catch (ArgumentException)
                    {
                    }
                }
            }
        }

        private void StreetTextBox_Leave(object sender, EventArgs e)
        {
            ValidateStreet();
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_address != null && !_isUpdatingFields)
            {
                if (ValidateBuilding())
                {
                    try
                    {
                        _address.Building = buildingTextBox.Text;
                        OnAddressChanged();
                    }
                    catch (ArgumentException)
                    {
                    }
                }
            }
        }

        private void BuildingTextBox_Leave(object sender, EventArgs e)
        {
            ValidateBuilding();
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_address != null && !_isUpdatingFields)
            {
                if (ValidateApartment())
                {
                    try
                    {
                        _address.Apartment = apartmentTextBox.Text;
                        OnAddressChanged();
                    }
                    catch (ArgumentException)
                    {
                    }
                }
            }
        }

        private void ApartmentTextBox_Leave(object sender, EventArgs e)
        {
            ValidateApartment();
        }

        #endregion
    }
}