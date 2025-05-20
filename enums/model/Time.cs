namespace Programming.Model
{
    /// <summary>
    /// Представляет время с часами, минутами и секундами.
    /// </summary>
    public class Time
    {
        private int _hours;    // Часы
        private int _minutes;  // Минуты
        private int _seconds;  // Секунды

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Time"/>.
        /// </summary>
        /// <param name="hours">Часы в диапазоне от 0 до 23.</param>
        /// <param name="minutes">Минуты в диапазоне от 0 до 59.</param>
        /// <param name="seconds">Секунды в диапазоне от 0 до 59.</param>
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Time"/> с заданными значениями по умолчанию.
        /// </summary>
        public Time() { }

        /// <summary>
        /// Возвращает и задаёт часы. 
        /// Должны быть в диапазоне от 0 до 23.
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
        /// Возвращает и задаёт минуты. 
        /// Должны быть в диапазоне от 0 до 59.
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
        /// Возвращает и задаёт секунды. 
        /// Должны быть в диапазоне от 0 до 59.
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