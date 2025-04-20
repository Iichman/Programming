using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model;
using Rectangle = Programming.Model.Rectangle;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private Rectangle[] _rectangles = new Rectangle[5];
        private Rectangle? _currentRectangle;
        private Movie[] _movies = new Movie[5];
        private Movie? _currentMovie;
        private Ring[] _rings = new Ring[5];
        private Ring? _currentRing;

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
            enumsListBox.Items.Clear();
            enumsListBox.Items.AddRange(new object[]
            {
                nameof(Weekday),
                nameof(Genre),
                nameof(Manufacturer),
                nameof(EducationForm),
                nameof(Season)
            });
            enumsListBox.SelectedIndex = 0;

            seasonComboBox.Items.Clear();
            seasonComboBox.Items.AddRange(Enum.GetNames(typeof(Season)));

            enumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            valuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            parseButton.Click += ParseButton_Click;
            goButton.Click += GoButton_Click;
        }

        private void InitializeClassesTab()
        {
            InitializeRectangles();
            InitializeMovies();
            InitializeRings();
        }

        private void InitializeRectangles()
        {
            Random random = new Random();

            for (int i = 0; i < _rectangles.Length; i++)
            {
                double width = random.Next(10, 100);
                double length = random.Next(10, 100);

                _rectangles[i] = new Rectangle(length, width, $"Color {i + 1}")
                {
                    Center = new Point2D(width / 2, length / 2)
                };

                _rectangles[i].OnCenterChanged += (sender, e) =>
                {
                    if (_currentRectangle == sender)
                    {
                        UpdateRectangleInfo();
                        UpdateCollisionPreview();
                    }
                };

                rectanglesListBox.Items.Add($"Rectangle {i + 1}");
            }

            rectanglesListBox.SelectedIndex = 0;

            rectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            lengthTextBox.TextChanged += LengthTextBox_TextChanged;
            widthTextBox.TextChanged += WidthTextBox_TextChanged;
            colorTextBox.TextChanged += ColorTextBox_TextChanged;
            findRectangleButton.Click += FindRectangleButton_Click;
            centerXTextBox.TextChanged += CenterXTextBox_TextChanged;
            centerYTextBox.TextChanged += CenterYTextBox_TextChanged;
        }

        private void InitializeMovies()
        {
            Random random = new Random();
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

            moviesListBox.SelectedIndexChanged += MoviesListBox_SelectedIndexChanged;
            titleTextBox.TextChanged += TitleTextBox_TextChanged;
            durationTextBox.TextChanged += DurationTextBox_TextChanged;
            yearTextBox.TextChanged += YearTextBox_TextChanged;
            genreTextBox.TextChanged += GenreTextBox_TextChanged;
            ratingTextBox.TextChanged += RatingTextBox_TextChanged;
            findMovieButton.Click += FindMovieButton_Click;
        }

        private void InitializeRings()
        {
            Random random = new Random();

            for (int i = 0; i < _rings.Length; i++)
            {
                double outerRadius = random.Next(10, 50);
                double innerRadius = random.Next(1, (int)outerRadius - 1);
                var center = new Point2D(random.Next(50, 200), random.Next(50, 200));
                _rings[i] = new Ring(outerRadius, innerRadius, center);
                ringsListBox.Items.Add($"Ring {i + 1}");
            }

            ringsListBox.SelectedIndex = 0;

            ringsListBox.SelectedIndexChanged += RingsListBox_SelectedIndexChanged;
            outerRadiusTextBox.TextChanged += OuterRadiusTextBox_TextChanged;
            innerRadiusTextBox.TextChanged += InnerRadiusTextBox_TextChanged;
            ringCenterXTextBox.TextChanged += RingCenterXTextBox_TextChanged;
            ringCenterYTextBox.TextChanged += RingCenterYTextBox_TextChanged;
            findRingButton.Click += FindRingButton_Click;
        }

        private void InitializeCollisionTab()
        {
            for (int i = 0; i < _rectangles.Length; i++)
            {
                rectangle1ComboBox.Items.Add($"Rectangle {i + 1}");
                rectangle2ComboBox.Items.Add($"Rectangle {i + 1}");
            }

            for (int i = 0; i < _rings.Length; i++)
            {
                ring1ComboBox.Items.Add($"Ring {i + 1}");
                ring2ComboBox.Items.Add($"Ring {i + 1}");
            }

            if (rectangle1ComboBox.Items.Count > 0)
                rectangle1ComboBox.SelectedIndex = 0;
            if (rectangle2ComboBox.Items.Count > 1)
                rectangle2ComboBox.SelectedIndex = 1;
            if (ring1ComboBox.Items.Count > 0)
                ring1ComboBox.SelectedIndex = 0;
            if (ring2ComboBox.Items.Count > 1)
                ring2ComboBox.SelectedIndex = 1;

            rectangle1ComboBox.SelectedIndexChanged += CollisionComboBox_SelectedIndexChanged;
            rectangle2ComboBox.SelectedIndexChanged += CollisionComboBox_SelectedIndexChanged;
            ring1ComboBox.SelectedIndexChanged += CollisionComboBox_SelectedIndexChanged;
            ring2ComboBox.SelectedIndexChanged += CollisionComboBox_SelectedIndexChanged;
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

        private void UpdateRingInfo()
        {
            if (_currentRing == null) return;

            outerRadiusTextBox.Text = _currentRing.OuterRadius.ToString("F2");
            innerRadiusTextBox.Text = _currentRing.InnerRadius.ToString("F2");
            ringCenterXTextBox.Text = _currentRing.Center.X.ToString("F2");
            ringCenterYTextBox.Text = _currentRing.Center.Y.ToString("F2");
            ringIdTextBox.Text = (Array.IndexOf(_rings, _currentRing) + 1).ToString();
        }

        private void UpdateCollisionPreview()
        {
            collisionResultLabel.Text = "";
            bool hasRectangleCollision = false;
            bool hasRingCollision = false;

            // Проверка прямоугольников
            if (rectangle1ComboBox.SelectedIndex != -1 &&
                rectangle2ComboBox.SelectedIndex != -1 &&
                rectangle1ComboBox.SelectedIndex < _rectangles.Length &&
                rectangle2ComboBox.SelectedIndex < _rectangles.Length)
            {
                var rect1 = _rectangles[rectangle1ComboBox.SelectedIndex];
                var rect2 = _rectangles[rectangle2ComboBox.SelectedIndex];
                bool isColliding = CollisionManager.IsCollision(rect1, rect2);

                collisionResultLabel.Text += $"Прямоугольники: {(isColliding ? "ПЕРЕСЕКАЮТСЯ" : "НЕ ПЕРЕСЕКАЮТСЯ")}";
                hasRectangleCollision = isColliding;
            }

            // Проверка колец
            if (ring1ComboBox.SelectedIndex != -1 &&
                ring2ComboBox.SelectedIndex != -1 &&
                ring1ComboBox.SelectedIndex < _rings.Length &&
                ring2ComboBox.SelectedIndex < _rings.Length)
            {
                if (!string.IsNullOrEmpty(collisionResultLabel.Text))
                {
                    collisionResultLabel.Text += Environment.NewLine;
                }

                var ring1 = _rings[ring1ComboBox.SelectedIndex];
                var ring2 = _rings[ring2ComboBox.SelectedIndex];
                bool isColliding = CollisionManager.IsCollision(ring1, ring2);

                collisionResultLabel.Text += $"Кольца: {(isColliding ? "ПЕРЕСЕКАЮТСЯ" : "НЕ ПЕРЕСЕКАЮТСЯ")}";
                hasRingCollision = isColliding;
            }

            // Установка цвета фона
            if (hasRectangleCollision || hasRingCollision)
            {
                collisionResultLabel.BackColor = System.Drawing.Color.LightGreen;
            }
            else if (!string.IsNullOrEmpty(collisionResultLabel.Text))
            {
                collisionResultLabel.BackColor = System.Drawing.Color.LightPink;
            }
            else
            {
                collisionResultLabel.BackColor = SystemColors.Control;
            }
        }

        private void EnumsListBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            valuesListBox.Items.Clear();
            if (enumsListBox.SelectedItem == null) return;

            string selectedEnum = enumsListBox.SelectedItem.ToString() ?? string.Empty;
            Type? enumType = Type.GetType($"Programming.Model.{selectedEnum}");

            if (enumType != null && enumType.IsEnum)
            {
                valuesListBox.Items.AddRange(Enum.GetNames(enumType));
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (valuesListBox.SelectedItem == null || enumsListBox.SelectedItem == null) return;
            indexListBox.Items.Clear();

            try
            {
                Type? enumType = Type.GetType($"Programming.Model.{enumsListBox.SelectedItem}");
                if (enumType != null && enumType.IsEnum)
                {
                    var value = Enum.Parse(enumType, valuesListBox.SelectedItem.ToString() ?? string.Empty);
                    indexListBox.Items.Add(((int)value).ToString());
                }
            }
            catch
            {
                // Игнорируем ошибки парсинга
            }
        }

        private void ParseButton_Click(object? sender, EventArgs e)
        {
            if (enumsListBox.SelectedItem != null && !string.IsNullOrEmpty(parseInputTextBox.Text))
            {
                try
                {
                    Type? enumType = Type.GetType($"Programming.Model.{enumsListBox.SelectedItem}");
                    if (enumType != null && enumType.IsEnum)
                    {
                        var value = Enum.Parse(enumType, parseInputTextBox.Text);
                        resultLabel.Text = $"Успешно: {value}";
                        resultLabel.BackColor = System.Drawing.Color.LightGreen;
                    }
                }
                catch
                {
                    resultLabel.Text = "Неверное значение для выбранного типа";
                    resultLabel.BackColor = System.Drawing.Color.LightPink;
                }
            }
        }

        private void GoButton_Click(object? sender, EventArgs e)
        {
            if (seasonComboBox.SelectedItem != null)
            {
                string selectedSeason = seasonComboBox.SelectedItem.ToString() ?? string.Empty;
                switch (selectedSeason)
                {
                    case "Summer":
                        MessageBox.Show("Ура! Солнце!", "Сезон", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "Autumn":
                        this.BackColor = System.Drawing.ColorTranslator.FromHtml("#e29c45");
                        break;
                    case "Winter":
                        MessageBox.Show("Бррр! Холодно!", "Сезон", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "Spring":
                        this.BackColor = System.Drawing.ColorTranslator.FromHtml("#559c45");
                        break;
                }
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (rectanglesListBox.SelectedIndex != -1)
            {
                _currentRectangle = _rectangles[rectanglesListBox.SelectedIndex];
                UpdateRectangleInfo();
            }
        }

        private void CenterXTextBox_TextChanged(object? sender, EventArgs e)
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

        private void CenterYTextBox_TextChanged(object? sender, EventArgs e)
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

        private void LengthTextBox_TextChanged(object? sender, EventArgs e)
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
                MessageBox.Show(ex.Message, "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WidthTextBox_TextChanged(object? sender, EventArgs e)
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
                MessageBox.Show(ex.Message, "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ColorTextBox_TextChanged(object? sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                _currentRectangle.Color = colorTextBox.Text;
            }
        }

        private void FindRectangleButton_Click(object? sender, EventArgs e)
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

        private void MoviesListBox_SelectedIndexChanged(object? sender, EventArgs e)
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

        private void TitleTextBox_TextChanged(object? sender, EventArgs e)
        {
            if (_currentMovie != null)
            {
                _currentMovie.Title = titleTextBox.Text;
            }
        }

        private void DurationTextBox_TextChanged(object? sender, EventArgs e)
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
                MessageBox.Show(ex.Message, "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void YearTextBox_TextChanged(object? sender, EventArgs e)
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
                MessageBox.Show(ex.Message, "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenreTextBox_TextChanged(object? sender, EventArgs e)
        {
            if (_currentMovie != null)
            {
                _currentMovie.Genre = genreTextBox.Text;
            }
        }

        private void RatingTextBox_TextChanged(object? sender, EventArgs e)
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
                MessageBox.Show(ex.Message, "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FindMovieButton_Click(object? sender, EventArgs e)
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

        private void RingsListBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (ringsListBox.SelectedIndex != -1)
            {
                _currentRing = _rings[ringsListBox.SelectedIndex];
                UpdateRingInfo();
            }
        }

        private void OuterRadiusTextBox_TextChanged(object? sender, EventArgs e)
        {
            if (_currentRing != null && double.TryParse(outerRadiusTextBox.Text, out double radius))
            {
                try
                {
                    _currentRing.OuterRadius = radius;
                    outerRadiusTextBox.BackColor = SystemColors.Window;
                    UpdateCollisionPreview();
                }
                catch
                {
                    outerRadiusTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
        }

        private void InnerRadiusTextBox_TextChanged(object? sender, EventArgs e)
        {
            if (_currentRing != null && double.TryParse(innerRadiusTextBox.Text, out double radius))
            {
                try
                {
                    _currentRing.InnerRadius = radius;
                    innerRadiusTextBox.BackColor = SystemColors.Window;
                }
                catch
                {
                    innerRadiusTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
        }

        private void RingCenterXTextBox_TextChanged(object? sender, EventArgs e)
        {
            if (_currentRing != null && double.TryParse(ringCenterXTextBox.Text, out double x))
            {
                try
                {
                    _currentRing.Center = new Point2D(x, _currentRing.Center.Y);
                    ringCenterXTextBox.BackColor = SystemColors.Window;
                    UpdateCollisionPreview();
                }
                catch
                {
                    ringCenterXTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
        }

        private void RingCenterYTextBox_TextChanged(object? sender, EventArgs e)
        {
            if (_currentRing != null && double.TryParse(ringCenterYTextBox.Text, out double y))
            {
                try
                {
                    _currentRing.Center = new Point2D(_currentRing.Center.X, y);
                    ringCenterYTextBox.BackColor = SystemColors.Window;
                    UpdateCollisionPreview();
                }
                catch
                {
                    ringCenterYTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
        }

        private void FindRingButton_Click(object? sender, EventArgs e)
        {
            int index = FindRingWithMaxArea();
            ringsListBox.SelectedIndex = index;
        }

        private int FindRingWithMaxArea()
        {
            double maxArea = 0;
            int index = 0;

            for (int i = 0; i < _rings.Length; i++)
            {
                if (_rings[i].Area > maxArea)
                {
                    maxArea = _rings[i].Area;
                    index = i;
                }
            }

            return index;
        }

        private void CollisionComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            UpdateCollisionPreview();
        }

        private void CheckCollisionButton_Click(object? sender, EventArgs e)
        {
            UpdateCollisionPreview();
        }
    }
}