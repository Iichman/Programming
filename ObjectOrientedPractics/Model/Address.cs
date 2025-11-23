using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет адрес доставки.
    /// </summary>
    public class Address
    {
        private int _index;
        private string _country = "";
        private string _city = "";
        private string _street = "";
        private string _building = "";
        private string _apartment = "";

        /// <summary>
        /// Создает экземпляр класса <see cref="Address"/> с пустыми значениями.
        /// </summary>
        public Address()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Address"/>.
        /// </summary>
        /// <param name="index">Почтовый индекс.</param>
        /// <param name="country">Страна/регион.</param>
        /// <param name="city">Город.</param>
        /// <param name="street">Улица.</param>
        /// <param name="building">Номер дома.</param>
        /// <param name="apartment">Номер квартиры.</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        /// <summary>
        /// Возвращает или задает почтовый индекс. Должен быть шестизначным числом.
        /// </summary>
        public int Index
        {
            get { return _index; }
            set
            {
                if (value < 100000 || value > 999999)
                {
                    throw new ArgumentException("Index must be a 6-digit number");
                }
                _index = value;
            }
        }

        /// <summary>
        /// Возвращает или задает страну/регион. Не более 50 символов.
        /// </summary>
        public string Country
        {
            get { return _country; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
                _country = value;
            }
        }

        /// <summary>
        /// Возвращает или задает город. Не более 50 символов.
        /// </summary>
        public string City
        {
            get { return _city; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(City));
                _city = value;
            }
        }

        /// <summary>
        /// Возвращает или задает улицу. Не более 100 символов.
        /// </summary>
        public string Street
        {
            get { return _street; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 100, nameof(Street));
                _street = value;
            }
        }

        /// <summary>
        /// Возвращает или задает номер дома. Не более 10 символов.
        /// </summary>
        public string Building
        {
            get { return _building; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Building));
                _building = value;
            }
        }

        /// <summary>
        /// Возвращает или задает номер квартиры. Не более 10 символов.
        /// </summary>
        public string Apartment
        {
            get { return _apartment; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment));
                _apartment = value;
            }
        }

        /// <summary>
        /// Возвращает строковое представление адреса.
        /// </summary>
        /// <returns>Строка с полным адресом.</returns>
        public override string ToString()
        {
            return $"{Index}, {Country}, {City}, {Street}, {Building}, {Apartment}";
        }
    }
}