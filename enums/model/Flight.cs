namespace Programming.Model
{
    /// <summary>
    /// Представляет информацию о рейсе, включая пункты отправления и назначения, а также время полета.
    /// </summary>
    public class Flight
    {
        private string _departurePoint;
        private string _destinationPoint;
        private int _flightTimeInMinutes;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Flight"/> с заданными параметрами.
        /// </summary>
        /// <param name="departurePoint">Пункт отправления. Не должен быть пустым.</param>
        /// <param name="destinationPoint">Пункт назначения. Не должен быть пустым.</param>
        /// <param name="flightTimeInMinutes">Время полета в минутах. Должно быть положительным числом.</param>
        public Flight(string departurePoint, string destinationPoint, int flightTimeInMinutes)
        {
            DeparturePoint = departurePoint;
            DestinationPoint = destinationPoint;
            FlightTimeInMinutes = flightTimeInMinutes;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Flight"/> с пустыми значениями.
        /// </summary>
        public Flight() { }

        /// <summary>
        /// Возвращает и задает пункт отправления рейса.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Возникает, если значение пустое или содержит только пробелы.
        /// </exception>
        public string DeparturePoint
        {
            get { return _departurePoint; }
            set
            {
                Validator.AssertStringNotNullOrEmpty(value, nameof(DeparturePoint));
                _departurePoint = value;
            }
        }

        /// <summary>
        /// Возвращает и задает пункт назначения рейса.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Возникает, если значение пустое или содержит только пробелы.
        /// </exception>
        public string DestinationPoint
        {
            get { return _destinationPoint; }
            set
            {
                Validator.AssertStringNotNullOrEmpty(value, nameof(DestinationPoint));
                _destinationPoint = value;
            }
        }

        /// <summary>
        /// Возвращает и задает время полета в минутах.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Возникает, если значение не является положительным числом.
        /// </exception>
        public int FlightTimeInMinutes
        {
            get { return _flightTimeInMinutes; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(FlightTimeInMinutes));
                _flightTimeInMinutes = value;
            }
        }
    }
}