namespace Programming.Model
{
    public class Flight
    {
        private string _departurePoint;
        private string _destinationPoint;
        private int _flightTimeInMinutes;

        public Flight(string departurePoint, string destinationPoint, int flightTimeInMinutes)
        {
            DeparturePoint = departurePoint;
            DestinationPoint = destinationPoint;
            FlightTimeInMinutes = flightTimeInMinutes;
        }

        public Flight() { }

        public string DeparturePoint
        {
            get { return _departurePoint; }
            set { _departurePoint = value; }
        }

        public string DestinationPoint
        {
            get { return _destinationPoint; }
            set { _destinationPoint = value; }
        }

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