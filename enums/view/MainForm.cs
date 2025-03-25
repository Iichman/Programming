using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model;
using ModelRectangle = Programming.Model.Rectangle;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private ModelRectangle[] _rectangles;
        private ModelRectangle _currentRectangle;
        private Movie[] _movies;
        private Movie _currentMovie;

        public MainForm()
        {
            InitializeComponent();
            InitializeEnumsTab();
            InitializeClassesTab();
        }

        private void InitializeEnumsTab()
        {
            enumsListBox.Items.AddRange(new object[]
            {
                nameof(Color),
                nameof(Weekday),
                nameof(Genre),
                nameof(Manufacturer),
                nameof(EducationForm),
                nameof(Season)
            });
            enumsListBox.SelectedIndex = 0;

            enumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            valuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            parseButton.Click += ParseButton_Click;
            goButton.Click += GoButton_Click;
        }

        private void InitializeClassesTab()
        {
            _rectangles = new ModelRectangle[5];
            Random random = new Random();
            for (int i = 0; i < _rectangles.Length; i++)
            {
                _rectangles[i] = new ModelRectangle(
                    random.Next(1, 100),
                    random.Next(1, 100),
                    $"Color {i + 1}");
                rectanglesListBox.Items.Add($"Rectangle {i + 1}");
            }
            rectanglesListBox.SelectedIndex = 0;

            _movies = new Movie[5];
            string[] genres = { "Action", "Comedy", "Drama", "Horror" };
            for (int i = 0; i < _movies.Length; i++)
            {
                _movies[i] = new Movie(
                    $"Movie {i + 1}",
                    random.Next(60, 180),
                    random.Next(1990, DateTime.Now.Year + 1),
                    genres[random.Next(genres.Length)],
                    Math.Round(random.NextDouble() * 10, 1));
                moviesListBox.Items.Add($"Movie {i + 1}");
            }
            moviesListBox.SelectedIndex = 0;

            rectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            lengthTextBox.TextChanged += LengthTextBox_TextChanged;
            widthTextBox.TextChanged += WidthTextBox_TextChanged;
            colorTextBox.TextChanged += ColorTextBox_TextChanged;
            findRectangleButton.Click += FindRectangleButton_Click;

            moviesListBox.SelectedIndexChanged += MoviesListBox_SelectedIndexChanged;
            titleTextBox.TextChanged += TitleTextBox_TextChanged;
            durationTextBox.TextChanged += DurationTextBox_TextChanged;
            yearTextBox.TextChanged += YearTextBox_TextChanged;
            genreTextBox.TextChanged += GenreTextBox_TextChanged;
            ratingTextBox.TextChanged += RatingTextBox_TextChanged;
            findMovieButton.Click += FindMovieButton_Click;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            valuesListBox.Items.Clear();
            indexListBox.Items.Clear();

            if (enumsListBox.SelectedItem != null)
            {
                string selectedEnumName = enumsListBox.SelectedItem.ToString();
                Type enumType = Type.GetType($"Programming.Model.{selectedEnumName}") ??
                                Type.GetType(selectedEnumName);

                if (enumType?.IsEnum == true)
                {
                    var values = Enum.GetValues(enumType);
                    foreach (var value in values)
                    {
                        valuesListBox.Items.Add(value);
                    }

                    if (valuesListBox.Items.Count > 0)
                    {
                        valuesListBox.SelectedIndex = 0;
                    }
                }
                else
                {
                    MessageBox.Show($"Перечисление {selectedEnumName} не найдено.");
                }
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexListBox.Items.Clear();
            if (valuesListBox.SelectedIndex != -1)
            {
                indexListBox.Items.Add(valuesListBox.SelectedIndex);
            }
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            string input = parseInputTextBox.Text.Trim();
            if (Enum.TryParse(typeof(Weekday), input, true, out var result))
            {
                if (Enum.IsDefined(typeof(Weekday), result))
                {
                    int dayNumber = (int)result + 1;
                    string dayName = Enum.GetName(typeof(Weekday), result);

                    resultLabel.Text = $"{input} - это день недели ({dayNumber})";
                }
                else
                {
                    resultLabel.Text = "Нет такого дня недели";
                }
            }
            else
            {
                resultLabel.Text = "Нет такого дня недели";
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            if (seasonComboBox.SelectedItem != null)
            {
                string selectedSeason = seasonComboBox.SelectedItem.ToString();
                switch (selectedSeason)
                {
                    case "Summer":
                        MessageBox.Show("Ура! Солнце!");
                        break;
                    case "Autumn":
                        this.BackColor = ColorTranslator.FromHtml("#e29c45");
                        break;
                    case "Winter":
                        MessageBox.Show("Бррр! Холодно!");
                        break;
                    case "Spring":
                        this.BackColor = ColorTranslator.FromHtml("#559c45");
                        break;
                }
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rectanglesListBox.SelectedIndex != -1)
            {
                _currentRectangle = _rectangles[rectanglesListBox.SelectedIndex];
                lengthTextBox.Text = _currentRectangle.Length.ToString();
                widthTextBox.Text = _currentRectangle.Width.ToString();
                colorTextBox.Text = _currentRectangle.Color;
            }
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentRectangle != null && double.TryParse(lengthTextBox.Text, out double length))
                {
                    _currentRectangle.Length = length;
                    lengthTextBox.BackColor = System.Drawing.Color.White;
                }
                else
                {
                    lengthTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
            catch (ArgumentException)
            {
                lengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentRectangle != null && double.TryParse(widthTextBox.Text, out double width))
                {
                    _currentRectangle.Width = width;
                    widthTextBox.BackColor = System.Drawing.Color.White;
                }
                else
                {
                    widthTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
            catch (ArgumentException)
            {
                widthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                _currentRectangle.Color = colorTextBox.Text;
            }
        }

        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            int index = FindRectangleWithMaxWidth();
            rectanglesListBox.SelectedIndex = index;
        }

        private int FindRectangleWithMaxWidth()
        {
            double maxWidth = 0;
            int index = 0;

            for (int i = 0; i < _rectangles.Length; i++)
            {
                if (_rectangles[i].Width > maxWidth)
                {
                    maxWidth = _rectangles[i].Width;
                    index = i;
                }
            }

            return index;
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (moviesListBox.SelectedIndex != -1)
            {
                _currentMovie = _movies[moviesListBox.SelectedIndex];
                titleTextBox.Text = _currentMovie.Title;
                durationTextBox.Text = _currentMovie.DurationInMinutes.ToString();
                yearTextBox.Text = _currentMovie.ReleaseYear.ToString();
                genreTextBox.Text = _currentMovie.Genre;
                ratingTextBox.Text = _currentMovie.Rating.ToString();
            }
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentMovie != null)
            {
                _currentMovie.Title = titleTextBox.Text;
            }
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentMovie != null && int.TryParse(durationTextBox.Text, out int duration))
                {
                    _currentMovie.DurationInMinutes = duration;
                    durationTextBox.BackColor = System.Drawing.Color.White;
                }
                else
                {
                    durationTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
            catch (ArgumentException)
            {
                durationTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentMovie != null && int.TryParse(yearTextBox.Text, out int year))
                {
                    _currentMovie.ReleaseYear = year;
                    yearTextBox.BackColor = System.Drawing.Color.White;
                }
                else
                {
                    yearTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
            catch (ArgumentException)
            {
                yearTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentMovie != null)
            {
                _currentMovie.Genre = genreTextBox.Text;
            }
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentMovie != null && double.TryParse(ratingTextBox.Text, out double rating))
                {
                    _currentMovie.Rating = rating;
                    ratingTextBox.BackColor = System.Drawing.Color.White;
                }
                else
                {
                    ratingTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
            catch (ArgumentException)
            {
                ratingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            int index = FindMovieWithMaxRating();
            moviesListBox.SelectedIndex = index;
        }

        private int FindMovieWithMaxRating()
        {
            double maxRating = 0;
            int index = 0;

            for (int i = 0; i < _movies.Length; i++)
            {
                if (_movies[i].Rating > maxRating)
                {
                    maxRating = _movies[i].Rating;
                    index = i;
                }
            }

            return index;
        }
    }
}