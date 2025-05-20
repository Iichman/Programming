namespace Programming.Model
{
    /// <summary>
    /// Представляет информацию о фильме, включая название, продолжительность, год выпуска, жанр и рейтинг.
    /// </summary>
    public class Movie
    {
        private string _title = string.Empty;
        private int _durationInMinutes;
        private int _releaseYear;
        private string _genre = string.Empty;
        private double _rating;

        /// <summary>
        /// Возвращает уникальный идентификатор фильма.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Movie"/> с заданными параметрами.
        /// </summary>
        /// <param name="id">Уникальный идентификатор фильма. Должен быть положительным числом.</param>
        /// <param name="title">Название фильма. Не может быть null или пустым.</param>
        /// <param name="durationInMinutes">Продолжительность в минутах. Должна быть положительным числом.</param>
        /// <param name="releaseYear">Год выпуска. Должен быть в диапазоне от 1900 до текущего года.</param>
        /// <param name="genre">Жанр фильма. Не может быть null или пустым.</param>
        /// <param name="rating">Рейтинг фильма. Должен быть в диапазоне от 0 до 10.</param>
        /// <exception cref="ArgumentNullException">Выбрасывается, если title или genre равны null.</exception>
        /// <exception cref="ArgumentException">Выбрасывается, если параметры не соответствуют ограничениям.</exception>
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
        /// Возвращает и задает название фильма.
        /// </summary>
        /// <exception cref="ArgumentNullException">Выбрасывается, если значение равно null.</exception>
        public string Title
        {
            get => _title;
            set => _title = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Возвращает и задает продолжительность фильма в минутах.
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается, если значение не является положительным числом.</exception>
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
        /// Возвращает и задает год выпуска фильма.
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается, если значение не входит в допустимый диапазон (1900-текущий год).</exception>
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
        /// Возвращает и задает жанр фильма.
        /// </summary>
        /// <exception cref="ArgumentNullException">Выбрасывается, если значение равно null.</exception>
        public string Genre
        {
            get => _genre;
            set => _genre = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Возвращает и задает рейтинг фильма.
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается, если значение не входит в допустимый диапазон (0-10).</exception>
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