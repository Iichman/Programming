using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model;
using Rectangle = Programming.Model.Rectangle;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private Rectangle[] _rectangles;
        private Rectangle _currentRectangle;
        private Movie[] _movies;
        private Movie _currentMovie;

        public MainForm()
        {
            InitializeComponent();

            idTextBox.ReadOnly = true;
            collisionResultLabel.AutoSize = true;

            InitializeEnumsTab();
            InitializeClassesTab();
            InitializeCollisionTab();
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
            // Инициализация массива прямоугольников
            _rectangles = new Rectangle[5];
            Random random = new Random();

            // Создаем 5 прямоугольников со случайными параметрами
            for (int i = 0; i < _rectangles.Length; i++)
            {
                // Генерируем случайные размеры
                double width = random.Next(10, 100);
                double length = random.Next(10, 100);

                // Создаем новый прямоугольник
                _rectangles[i] = new Rectangle(length, width, $"Color {i + 1}")
                {
                    // Явно задаем начальный центр (можно убрать, так как он задается в конструкторе)
                    Center = new Point2D(width / 2, length / 2)
                };

                // Подписываемся на событие изменения центра
                _rectangles[i].OnCenterChanged += (sender, e) =>
                {
                    // Если изменяется центр текущего выбранного прямоугольника
                    if (_currentRectangle == sender)
                    {
                        // Обновляем информацию на форме
                        UpdateRectangleInfo();

                        // Проверяем коллизии
                        UpdateCollisionPreview();
                    }
                };

                // Добавляем прямоугольник в список
                rectanglesListBox.Items.Add($"Rectangle {i + 1}");
            }

            // Выбираем первый прямоугольник по умолчанию
            rectanglesListBox.SelectedIndex = 0;

            // Инициализация массива фильмов
            _movies = new Movie[5];
            string[] genres = { "Action", "Comedy", "Drama", "Horror" };

            // Создаем 5 фильмов со случайными параметрами
            for (int i = 0; i < _movies.Length; i++)
            {
                _movies[i] = new Movie(
                    $"Movie {i + 1}",
                    random.Next(60, 180), // Длительность 60-180 минут
                    random.Next(1990, DateTime.Now.Year + 1), // Год выпуска
                    genres[random.Next(genres.Length)], // Случайный жанр
                    Math.Round(random.NextDouble() * 10, 1) // Рейтинг 0-10
                );

                moviesListBox.Items.Add($"Movie {i + 1}");
            }

            // Выбираем первый фильм по умолчанию
            moviesListBox.SelectedIndex = 0;

            // Подписываемся на события для прямоугольников
            rectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            lengthTextBox.TextChanged += LengthTextBox_TextChanged;
            widthTextBox.TextChanged += WidthTextBox_TextChanged;
            colorTextBox.TextChanged += ColorTextBox_TextChanged;
            findRectangleButton.Click += FindRectangleButton_Click;
            centerXTextBox.TextChanged += CenterXTextBox_TextChanged;
            centerYTextBox.TextChanged += CenterYTextBox_TextChanged;

            // Подписываемся на события для фильмов
            moviesListBox.SelectedIndexChanged += MoviesListBox_SelectedIndexChanged;
            titleTextBox.TextChanged += TitleTextBox_TextChanged;
            durationTextBox.TextChanged += DurationTextBox_TextChanged;
            yearTextBox.TextChanged += YearTextBox_TextChanged;
            genreTextBox.TextChanged += GenreTextBox_TextChanged;
            ratingTextBox.TextChanged += RatingTextBox_TextChanged;
            findMovieButton.Click += FindMovieButton_Click;
        }

        private void InitializeCollisionTab()
        {
            // Заполнение ComboBox для выбора прямоугольников
            foreach (var rect in _rectangles)
            {
                rectangle1ComboBox.Items.Add($"Rectangle {rect.Id}");
                rectangle2ComboBox.Items.Add($"Rectangle {rect.Id}");
            }

            if (rectangle1ComboBox.Items.Count > 0)
                rectangle1ComboBox.SelectedIndex = 0;
            if (rectangle2ComboBox.Items.Count > 1)
                rectangle2ComboBox.SelectedIndex = 1;

            rectangle1ComboBox.SelectedIndexChanged += CollisionComboBox_SelectedIndexChanged;
            rectangle2ComboBox.SelectedIndexChanged += CollisionComboBox_SelectedIndexChanged;
            checkCollisionButton.Click += CheckCollisionButton_Click;
        }

        private void UpdateRectangleInfo()
        {
            if (_currentRectangle == null) return;

            lengthTextBox.Text = _currentRectangle.Length.ToString("F2");
            widthTextBox.Text = _currentRectangle.Width.ToString("F2");
            colorTextBox.Text = _currentRectangle.Color;
            idTextBox.Text = _currentRectangle.Id.ToString();
            centerXTextBox.Text = _currentRectangle.Center.X.ToString("F2");
            centerYTextBox.Text = _currentRectangle.Center.Y.ToString("F2");
        }

        private void UpdateCollisionPreview()
        {
            if (rectangle1ComboBox.SelectedIndex == -1 ||
                rectangle2ComboBox.SelectedIndex == -1)
                return;

            var rect1 = _rectangles[rectangle1ComboBox.SelectedIndex];
            var rect2 = _rectangles[rectangle2ComboBox.SelectedIndex];

            bool isColliding = CollisionManager.IsCollision(rect1, rect2);

            collisionResultLabel.Text = isColliding ? "ПЕРЕСЕКАЮТСЯ" : "НЕ ПЕРЕСЕКАЮТСЯ";
            collisionResultLabel.BackColor = isColliding ? System.Drawing.Color.LightGreen : System.Drawing.Color.LightPink;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            valuesListBox.Items.Clear();
            if (enumsListBox.SelectedItem == null) return;

            string selectedEnum = enumsListBox.SelectedItem.ToString();
            Type enumType = Type.GetType($"Programming.Model.{selectedEnum}");

            if (enumType != null && enumType.IsEnum)
            {
                valuesListBox.Items.AddRange(Enum.GetNames(enumType));
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (valuesListBox.SelectedItem == null) return;
            indexListBox.Items.Clear();
            indexListBox.Items.Add(((int)Enum.Parse(
                Type.GetType($"Programming.Model.{enumsListBox.SelectedItem}"),
                valuesListBox.SelectedItem.ToString())).ToString());
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            if (enumsListBox.SelectedItem != null && parseInputTextBox.Text != "")
            {
                try
                {
                    var enumType = Type.GetType($"Programming.Model.{enumsListBox.SelectedItem}");
                    var value = Enum.Parse(enumType, parseInputTextBox.Text);
                    resultLabel.Text = $"Успешно: {value}";
                    resultLabel.BackColor = System.Drawing.Color.LightGreen;
                }
                catch
                {
                    resultLabel.Text = "Неверное значение для выбранного типа";
                    resultLabel.BackColor = System.Drawing.Color.LightPink;
                }
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
                        MessageBox.Show("Ура! Солнце!", "Сезон",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "Autumn":
                        this.BackColor = ColorTranslator.FromHtml("#e29c45");
                        break;
                    case "Winter":
                        MessageBox.Show("Бррр! Холодно!", "Сезон",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                UpdateRectangleInfo();
            }
        }

        private void CenterXTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null && double.TryParse(centerXTextBox.Text, out double x))
            {
                try
                {
                    _currentRectangle.Center = new Point2D(x, _currentRectangle.Center.Y);
                    centerXTextBox.BackColor = SystemColors.Window;
                    UpdateCollisionPreview();
                }
                catch
                {
                    centerXTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
        }

        private void CenterYTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null && double.TryParse(centerYTextBox.Text, out double y))
            {
                try
                {
                    _currentRectangle.Center = new Point2D(_currentRectangle.Center.X, y);
                    centerYTextBox.BackColor = SystemColors.Window;
                    UpdateCollisionPreview();
                }
                catch
                {
                    centerYTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentRectangle != null && double.TryParse(lengthTextBox.Text, out double length))
                {
                    _currentRectangle.Length = length;
                    lengthTextBox.BackColor = SystemColors.Window;
                }
                else
                {
                    lengthTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
            catch (ArgumentException ex)
            {
                lengthTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка валидации",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentRectangle != null && double.TryParse(widthTextBox.Text, out double width))
                {
                    _currentRectangle.Width = width;
                    widthTextBox.BackColor = SystemColors.Window;
                }
                else
                {
                    widthTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
            catch (ArgumentException ex)
            {
                widthTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка валидации",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    Validator.AssertOnPositiveValue(duration, nameof(Movie.DurationInMinutes));
                    _currentMovie.DurationInMinutes = duration;
                    durationTextBox.BackColor = SystemColors.Window;
                }
                else
                {
                    durationTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
            catch (ArgumentException ex)
            {
                durationTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка валидации",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentMovie != null && int.TryParse(yearTextBox.Text, out int year))
                {
                    Validator.AssertValueInRange(year, 1900, DateTime.Now.Year, nameof(Movie.ReleaseYear));
                    _currentMovie.ReleaseYear = year;
                    yearTextBox.BackColor = SystemColors.Window;
                }
                else
                {
                    yearTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
            catch (ArgumentException ex)
            {
                yearTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка валидации",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    Validator.AssertValueInRange(rating, 0, 10, nameof(Movie.Rating));
                    _currentMovie.Rating = rating;
                    ratingTextBox.BackColor = SystemColors.Window;
                }
                else
                {
                    ratingTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
            catch (ArgumentException ex)
            {
                ratingTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка валидации",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void CollisionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCollisionPreview();
        }

        private void CheckCollisionButton_Click(object sender, EventArgs e)
        {
            UpdateCollisionPreview();
        }
    }
}