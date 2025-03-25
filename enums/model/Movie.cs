using System;

namespace Programming.Model
{
    public class Movie
    {
        private string _title;
        private int _durationInMinutes;
        private int _releaseYear;
        private string _genre;
        private double _rating;

        public Movie(string title, int durationInMinutes, int releaseYear, string genre, double rating)
        {
            Title = title;
            DurationInMinutes = durationInMinutes;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
        }

        public Movie() { }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public int DurationInMinutes
        {
            get { return _durationInMinutes; }
            set { _durationInMinutes = value; }
        }

        public int ReleaseYear
        {
            get { return _releaseYear; }
            set
            {
                if (value < 1900 || value > DateTime.Now.Year)
                    throw new ArgumentException("Release year must be between 1900 and the current year.");
                _releaseYear = value;
            }
        }

        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        public double Rating
        {
            get { return _rating; }
            set
            {
                if (value < 0 || value > 10)
                    throw new ArgumentException("Rating must be between 0 and 10.");
                _rating = value;
            }
        }
    }
}