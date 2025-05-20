using System;
using System.Windows.Forms;
using Programming.Model;

namespace Programming.View.Controls
{
    /// <summary>
    /// Представляет элемент управления для отображения и управления списком фильмов.
    /// </summary>
    public partial class MoviesControl : UserControl
    {
        private Movie[] _movies = new Movie[5];
        private Movie? _currentMovie;
        private int _nextMovieId = 1;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="MoviesControl"/>.
        /// </summary>
        public MoviesControl()
        {
            InitializeComponent();
            InitializeMovies();
        }

        /// <summary>
        /// Инициализирует массив фильмов случайными значениями и заполняет список.
        /// </summary>
        private void InitializeMovies()
        {
            Random random = new Random();
            string[] genres = Enum.GetNames(typeof(Genre));

            for (int i = 0; i < _movies.Length; i++)
            {
                _movies[i] = new Movie(
                    _nextMovieId++,
                    $"Movie {i + 1}",
                    random.Next(60, 180),
                    random.Next(1990, DateTime.Now.Year + 1),
                    genres[random.Next(genres.Length)],
                    Math.Round(random.NextDouble() * 10, 1));

                moviesListBox.Items.Add($"Movie {i + 1}");
            }
            moviesListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Обрабатывает событие изменения выбора в списке фильмов.
        /// Загружает информацию о выбранном фильме.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект события.</param>
        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (moviesListBox.SelectedIndex == -1) return;

            try
            {
                _currentMovie = _movies[moviesListBox.SelectedIndex];
                titleTextBox.Text = _currentMovie.Title;
                durationTextBox.Text = _currentMovie.DurationInMinutes.ToString();
                yearTextBox.Text = _currentMovie.ReleaseYear.ToString();
                genreTextBox.Text = _currentMovie.Genre;
                ratingTextBox.Text = _currentMovie.Rating.ToString("F1");

                durationTextBox.BackColor = System.Drawing.Color.White;
                yearTextBox.BackColor = System.Drawing.Color.White;
                ratingTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading movie: {ex.Message}", "Error");
            }
        }

        /// <summary>
        /// Обрабатывает событие изменения текста в текстовом поле фильма.
        /// Обновляет свойства текущего фильма на основе ввода пользователя.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект события.</param>
        private void MovieTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentMovie == null) return;

            var textBox = (TextBox)sender;
            try
            {
                if (string.IsNullOrWhiteSpace(textBox.Text)) return;

                if (sender == durationTextBox)
                {
                    _currentMovie.DurationInMinutes = Validator.AssertOnPositiveValue(
                        int.Parse(durationTextBox.Text), "Duration");
                }
                else if (sender == yearTextBox)
                {
                    _currentMovie.ReleaseYear = Validator.AssertValueInRange(
                        int.Parse(yearTextBox.Text), 1900, DateTime.Now.Year, "Release Year");
                }
                else if (sender == ratingTextBox)
                {
                    _currentMovie.Rating = Validator.AssertValueInRange(
                        double.Parse(ratingTextBox.Text), 0, 10, "Rating");
                }

                textBox.BackColor = System.Drawing.Color.White;
            }
            catch (FormatException)
            {
                textBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (ArgumentException ex)
            {
                textBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show(ex.Message, "Validation Error");
            }
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки для поиска фильма с максимальным рейтингом.
        /// Выделяет фильм с наивысшим рейтингом в списке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект события.</param>
        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            if (_movies.Length == 0) return;

            try
            {
                Movie maxRatingMovie = _movies[0];
                foreach (var movie in _movies)
                {
                    if (movie.Rating > maxRatingMovie.Rating)
                    {
                        maxRatingMovie = movie;
                    }
                }

                moviesListBox.SelectedIndex = Array.IndexOf(_movies, maxRatingMovie);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error finding movie: {ex.Message}", "Error");
            }
        }
    }
}