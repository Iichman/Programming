namespace Programming.Model
{
    /// <summary>
    /// ������������ ����� � ������, �������� � ���������.
    /// </summary>
    public class Time
    {
        private int _hours;    // ����
        private int _minutes;  // ������
        private int _seconds;  // �������

        /// <summary>
        /// ������ ��������� ������ <see cref="Time"/>.
        /// </summary>
        /// <param name="hours">���� � ��������� �� 0 �� 23.</param>
        /// <param name="minutes">������ � ��������� �� 0 �� 59.</param>
        /// <param name="seconds">������� � ��������� �� 0 �� 59.</param>
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        /// <summary>
        /// ������ ��������� ������ <see cref="Time"/> � ��������� ���������� �� ���������.
        /// </summary>
        public Time() { }

        /// <summary>
        /// ���������� � ����� ����. 
        /// ������ ���� � ��������� �� 0 �� 23.
        /// </summary>
        public int Hours
        {
            get { return _hours; }
            set
            {
                Validator.AssertValueInRange(value, 0, 23, nameof(Hours));
                _hours = value;
            }
        }

        /// <summary>
        /// ���������� � ����� ������. 
        /// ������ ���� � ��������� �� 0 �� 59.
        /// </summary>
        public int Minutes
        {
            get { return _minutes; }
            set
            {
                Validator.AssertValueInRange(value, 0, 59, nameof(Minutes));
                _minutes = value;
            }
        }

        /// <summary>
        /// ���������� � ����� �������. 
        /// ������ ���� � ��������� �� 0 �� 59.
        /// </summary>
        public int Seconds
        {
            get { return _seconds; }
            set
            {
                Validator.AssertValueInRange(value, 0, 59, nameof(Seconds));
                _seconds = value;
            }
        }
    }
}