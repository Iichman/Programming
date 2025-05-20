namespace Programming.Model
{
    /// <summary>
    /// Представляет музыкальную композицию с заголовком, исполнителем и продолжительностью.
    /// </summary>
    public class Song
    {
        private string _title;               // Заголовок песни
        private string _artist;              // Исполнитель песни
        private int _durationInSeconds;      // Продолжительность песни в секундах

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="title">Заголовок песни.</param>
        /// <param name="artist">Исполнитель песни.</param>
        /// <param name="durationInSeconds">Продолжительность песни в секундах.</param>
        public Song(string title, string artist, int durationInSeconds)
        {
            Title = title;
            Artist = artist;
            DurationInSeconds = durationInSeconds;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/> с заданными значениями по умолчанию.
        /// </summary>
        public Song() { }

        /// <summary>
        /// Возвращает и задаёт заголовок песни.
        /// </summary>
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        /// <summary>
        /// Возвращает и задаёт исполнителя песни.
        /// </summary>
        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }

        /// <summary>
        /// Возвращает и задаёт продолжительность песни в секундах. 
        /// Должна быть положительным значением.
        /// </summary>
        public int DurationInSeconds
        {
            get { return _durationInSeconds; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(DurationInSeconds));
                _durationInSeconds = value;
            }
        }
    }
}