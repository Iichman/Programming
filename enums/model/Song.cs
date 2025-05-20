namespace Programming.Model
{
    /// <summary>
    /// ������������ ����������� ���������� � ����������, ������������ � ������������������.
    /// </summary>
    public class Song
    {
        private string _title;               // ��������� �����
        private string _artist;              // ����������� �����
        private int _durationInSeconds;      // ����������������� ����� � ��������

        /// <summary>
        /// ������ ��������� ������ <see cref="Song"/>.
        /// </summary>
        /// <param name="title">��������� �����.</param>
        /// <param name="artist">����������� �����.</param>
        /// <param name="durationInSeconds">����������������� ����� � ��������.</param>
        public Song(string title, string artist, int durationInSeconds)
        {
            Title = title;
            Artist = artist;
            DurationInSeconds = durationInSeconds;
        }

        /// <summary>
        /// ������ ��������� ������ <see cref="Song"/> � ��������� ���������� �� ���������.
        /// </summary>
        public Song() { }

        /// <summary>
        /// ���������� � ����� ��������� �����.
        /// </summary>
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        /// <summary>
        /// ���������� � ����� ����������� �����.
        /// </summary>
        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }

        /// <summary>
        /// ���������� � ����� ����������������� ����� � ��������. 
        /// ������ ���� ������������� ���������.
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