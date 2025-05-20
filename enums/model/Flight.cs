namespace Programming.Model
{
    /// <summary>
    /// ������������ ���������� � �����, ������� ������ ����������� � ����������, � ����� ����� ������.
    /// </summary>
    public class Flight
    {
        private string _departurePoint;
        private string _destinationPoint;
        private int _flightTimeInMinutes;

        /// <summary>
        /// �������������� ����� ��������� ������ <see cref="Flight"/> � ��������� �����������.
        /// </summary>
        /// <param name="departurePoint">����� �����������. �� ������ ���� ������.</param>
        /// <param name="destinationPoint">����� ����������. �� ������ ���� ������.</param>
        /// <param name="flightTimeInMinutes">����� ������ � �������. ������ ���� ������������� ������.</param>
        public Flight(string departurePoint, string destinationPoint, int flightTimeInMinutes)
        {
            DeparturePoint = departurePoint;
            DestinationPoint = destinationPoint;
            FlightTimeInMinutes = flightTimeInMinutes;
        }

        /// <summary>
        /// �������������� ����� ��������� ������ <see cref="Flight"/> � ������� ����������.
        /// </summary>
        public Flight() { }

        /// <summary>
        /// ���������� � ������ ����� ����������� �����.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// ���������, ���� �������� ������ ��� �������� ������ �������.
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
        /// ���������� � ������ ����� ���������� �����.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// ���������, ���� �������� ������ ��� �������� ������ �������.
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
        /// ���������� � ������ ����� ������ � �������.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// ���������, ���� �������� �� �������� ������������� ������.
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