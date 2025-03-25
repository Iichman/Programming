using System;

namespace Programming.Model
{
    public class Time
    {
        private int _hours;
        private int _minutes;
        private int _seconds;

        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Time() { }

        public int Hours
        {
            get { return _hours; }
            set
            {
                if (value < 0 || value > 23)
                    throw new ArgumentException("Hours must be between 0 and 23.");
                _hours = value;
            }
        }

        public int Minutes
        {
            get { return _minutes; }
            set
            {
                if (value < 0 || value > 59)
                    throw new ArgumentException("Minutes must be between 0 and 59.");
                _minutes = value;
            }
        }

        public int Seconds
        {
            get { return _seconds; }
            set
            {
                if (value < 0 || value > 59)
                    throw new ArgumentException("Seconds must be between 0 and 59.");
                _seconds = value;
            }
        }
    }
}