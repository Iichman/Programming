namespace Programming.Model
{
    /// <summary>
    /// ������������ ���������� � ������, ������� ��������, �����������������, ��� �������, ���� � �������.
    /// </summary>
    public class Movie
    {
        private string _title = string.Empty;
        private int _durationInMinutes;
        private int _releaseYear;
        private string _genre = string.Empty;
        private double _rating;

        /// <summary>
        /// ���������� ���������� ������������� ������.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// �������������� ����� ��������� ������ <see cref="Movie"/> � ��������� �����������.
        /// </summary>
        /// <param name="id">���������� ������������� ������. ������ ���� ������������� ������.</param>
        /// <param name="title">�������� ������. �� ����� ���� null ��� ������.</param>
        /// <param name="durationInMinutes">����������������� � �������. ������ ���� ������������� ������.</param>
        /// <param name="releaseYear">��� �������. ������ ���� � ��������� �� 1900 �� �������� ����.</param>
        /// <param name="genre">���� ������. �� ����� ���� null ��� ������.</param>
        /// <param name="rating">������� ������. ������ ���� � ��������� �� 0 �� 10.</param>
        /// <exception cref="ArgumentNullException">�������������, ���� title ��� genre ����� null.</exception>
        /// <exception cref="ArgumentException">�������������, ���� ��������� �� ������������� ������������.</exception>
        public Movie(int id, string title, int durationInMinutes, int releaseYear, string genre, double rating)
        {
            Id = id;
            Title = title;
            DurationInMinutes = durationInMinutes;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
        }

        /// <summary>
        /// ���������� � ������ �������� ������.
        /// </summary>
        /// <exception cref="ArgumentNullException">�������������, ���� �������� ����� null.</exception>
        public string Title
        {
            get => _title;
            set => _title = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// ���������� � ������ ����������������� ������ � �������.
        /// </summary>
        /// <exception cref="ArgumentException">�������������, ���� �������� �� �������� ������������� ������.</exception>
        public int DurationInMinutes
        {
            get => _durationInMinutes;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(DurationInMinutes));
                _durationInMinutes = value;
            }
        }

        /// <summary>
        /// ���������� � ������ ��� ������� ������.
        /// </summary>
        /// <exception cref="ArgumentException">�������������, ���� �������� �� ������ � ���������� �������� (1900-������� ���).</exception>
        public int ReleaseYear
        {
            get => _releaseYear;
            set
            {
                Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, nameof(ReleaseYear));
                _releaseYear = value;
            }
        }

        /// <summary>
        /// ���������� � ������ ���� ������.
        /// </summary>
        /// <exception cref="ArgumentNullException">�������������, ���� �������� ����� null.</exception>
        public string Genre
        {
            get => _genre;
            set => _genre = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// ���������� � ������ ������� ������.
        /// </summary>
        /// <exception cref="ArgumentException">�������������, ���� �������� �� ������ � ���������� �������� (0-10).</exception>
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