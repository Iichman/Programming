using System;
using System.Text.RegularExpressions;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет адрес доставки.
    /// </summary>
    public class Address : ICloneable, IEquatable<Address>
    {
        private string _postIndex;
        private string _country;
        private string _city;
        private string _street;
        private string _building;
        private string _apartment;

        /// <summary>
        /// Событие изменения адреса.
        /// </summary>
        public event EventHandler AddressChanged;

        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        public string PostIndex
        {
            get => _postIndex;
            set
            {
                if (_postIndex != value)
                { 
                    if (!string.IsNullOrEmpty(value) && !IsValidPostIndex(value))
                    {
                        throw new ArgumentException("Почтовый индекс должен содержать 6 цифр.");
                    }
                    _postIndex = value;
                    OnAddressChanged();
                }
            }
        }

        /// <summary>
        /// Страна.
        /// </summary>
        public string Country
        {
            get => _country;
            set
            {
                if (_country != value)
                {
                    if (!string.IsNullOrEmpty(value) && !IsValidName(value))
                    {
                        throw new ArgumentException("Название страны может содержать только буквы и пробелы.");
                    }
                    _country = value;
                    OnAddressChanged();
                }
            }
        }

        /// <summary>
        /// Город.
        /// </summary>
        public string City
        {
            get => _city;
            set
            {
                if (_city != value)
                {
                    if (!string.IsNullOrEmpty(value) && !IsValidName(value))
                    {
                        throw new ArgumentException("Название города может содержать только буквы и пробелы.");
                    }
                    _city = value;
                    OnAddressChanged();
                }
            }
        }

        /// <summary>
        /// Улица.
        /// </summary>
        public string Street
        {
            get => _street;
            set
            {
                if (_street != value)
                {
                    _street = value;
                    OnAddressChanged();
                }
            }
        }

        /// <summary>
        /// Здание.
        /// </summary>
        public string Building
        {
            get => _building;
            set
            {
                if (_building != value)
                {
                    _building = value;
                    OnAddressChanged();
                }
            }
        }

        /// <summary>
        /// Квартира/офис.
        /// </summary>
        public string Apartment
        {
            get => _apartment;
            set
            {
                if (_apartment != value)
                {
                    _apartment = value;
                    OnAddressChanged();
                }
            }
        }

        /// <summary>
        /// Проверяет, является ли почтовый индекс валидным.
        /// </summary>
        /// <param name="postIndex">Почтовый индекс для проверки.</param>
        /// <returns>true, если индекс валиден; иначе false.</returns>
        private bool IsValidPostIndex(string postIndex)
        {
            return Regex.IsMatch(postIndex, @"^\d{6}$");
        }

        /// <summary>
        /// Проверяет, является ли название валидным (только буквы и пробелы).
        /// </summary>
        /// <param name="name">Название для проверки.</param>
        /// <returns>true, если название валидно; иначе false.</returns>
        private bool IsValidName(string name)
        {
            return Regex.IsMatch(name, @"^[a-zA-Zа-яА-ЯёЁ\s\-]+$");
        }

        /// <summary>
        /// Создает новый адрес.
        /// </summary>
        public Address()
        {
        }

        /// <summary>
        /// Создает адрес с заданными параметрами.
        /// </summary>
        public Address(string postIndex, string country, string city,
                      string street, string building, string apartment)
        {
            PostIndex = postIndex;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        /// <summary>
        /// Вызывает событие изменения адреса.
        /// </summary>
        protected virtual void OnAddressChanged()
        {
            AddressChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Создает копию адреса.
        /// </summary>
        public object Clone()
        {
            return new Address(PostIndex, Country, City, Street, Building, Apartment);
        }

        /// <summary>
        /// Сравнивает текущий адрес с другим адресом.
        /// </summary>
        public bool Equals(Address other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return PostIndex == other.PostIndex &&
                   Country == other.Country &&
                   City == other.City &&
                   Street == other.Street &&
                   Building == other.Building &&
                   Apartment == other.Apartment;
        }

        /// <summary>
        /// Сравнивает текущий адрес с другим объектом.
        /// </summary>
        public override bool Equals(object obj)
        {
            return Equals(obj as Address);
        }

        /// <summary>
        /// Возвращает хэш-код адреса.
        /// </summary>
        public override int GetHashCode()
        {
            return HashCode.Combine(PostIndex, Country, City, Street, Building, Apartment);
        }

        /// <summary>
        /// Проверяет равенство двух адресов.
        /// </summary>
        public static bool operator ==(Address left, Address right)
        {
            if (ReferenceEquals(left, right)) return true;
            if (left is null || right is null) return false;
            return left.Equals(right);
        }

        /// <summary>
        /// Проверяет неравенство двух адресов.
        /// </summary>
        public static bool operator !=(Address left, Address right)
        {
            return !(left == right);
        }

        /// <summary>
        /// Возвращает строковое представление адреса.
        /// </summary>
        public override string ToString()
        {
            return $"{PostIndex}, {Country}, {City}, {Street}, {Building}, {Apartment}";
        }
    }
}