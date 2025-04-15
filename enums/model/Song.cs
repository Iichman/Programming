namespace Programming.Model
{
    public class Song
    {
        private string _title;
        private string _artist;
        private int _durationInSeconds;

        public Song(string title, string artist, int durationInSeconds)
        {
            Title = title;
            Artist = artist;
            DurationInSeconds = durationInSeconds;
        }

        public Song() { }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }

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