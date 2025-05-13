namespace Programming.Model
{
    public class Movie
    {
        private string _title;
        private int _durationInMinutes;
        private int _releaseYear;
        private string _genre;
        private double _rating;

        public int Id { get; }

        public Movie(int id, string title, int durationInMinutes, int releaseYear, string genre, double rating)
        {
            Id = id;
            Title = title;
            DurationInMinutes = durationInMinutes;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
        }

        public string Title
        {
            get => _title;
            set => _title = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int DurationInMinutes
        {
            get => _durationInMinutes;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(DurationInMinutes));
                _durationInMinutes = value;
            }
        }

        public int ReleaseYear
        {
            get => _releaseYear;
            set
            {
                Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, nameof(ReleaseYear));
                _releaseYear = value;
            }
        }

        public string Genre
        {
            get => _genre;
            set => _genre = value ?? throw new ArgumentNullException(nameof(value));
        }

        public double Rating
        {
            get => _rating;
            set
            {
                Validator.AssertValueInRange(value, 0, 10, nameof(Rating));
                _rating = value;
            }
        }
    }
}