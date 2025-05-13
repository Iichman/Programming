using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model;
using Programming.Model.Factories;
using Rectangle = Programming.Model.Rectangle;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private List<Rectangle> _rectangles = new List<Rectangle>();
        private List<Panel> _rectanglePanels = new List<Panel>();
        private Rectangle? _currentRectangle;
        private Movie[] _movies = new Movie[5];
        private Movie? _currentMovie;
        private Ring[] _rings = new Ring[5];
        private Ring? _currentRing;
        private int _nextMovieId = 1;
        private int _nextRingId = 1;

        public MainForm()
        {
            InitializeComponent();
            InitializeEnumsTab();
            InitializeClassesTab();
            InitializeRectanglesTab();
            InitializeCollisionTab();
        }

        private void InitializeEnumsTab()
        {
            enumsListBox.Items.AddRange(new[]
            {
                nameof(Weekday),
                nameof(Genre),
                nameof(Color),
                nameof(EducationForm),
                nameof(Manufacturer),
                nameof(Season)
            });
            enumsListBox.SelectedIndex = 0;

            seasonComboBox.DataSource = Enum.GetValues(typeof(Season));
            seasonComboBox.SelectedIndex = 0;

            enumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            valuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            parseButton.Click += ParseButton_Click;
            goButton.Click += GoButton_Click;
        }

        private Type GetEnumType(string enumName)
        {
            switch (enumName)
            {
                case nameof(Weekday): return typeof(Weekday);
                case nameof(Genre): return typeof(Genre);
                case nameof(Color): return typeof(Color);
                case nameof(EducationForm): return typeof(EducationForm);
                case nameof(Manufacturer): return typeof(Manufacturer);
                case nameof(Season): return typeof(Season);
                default: return null;
            }
        }

        private void EnumsListBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            valuesListBox.Items.Clear();
            indexListBox.Items.Clear();

            if (enumsListBox.SelectedItem == null) return;

            try
            {
                Type enumType = GetEnumType(enumsListBox.SelectedItem.ToString());
                if (enumType != null && enumType.IsEnum)
                {
                    foreach (var value in Enum.GetNames(enumType))
                    {
                        valuesListBox.Items.Add(value);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading enum: {ex.Message}", "Error");
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            indexListBox.Items.Clear();
            if (valuesListBox.SelectedItem == null || enumsListBox.SelectedItem == null) return;

            try
            {
                Type enumType = GetEnumType(enumsListBox.SelectedItem.ToString());
                if (enumType != null && enumType.IsEnum)
                {
                    var value = Enum.Parse(enumType, valuesListBox.SelectedItem.ToString());
                    indexListBox.Items.Add((int)value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting enum value: {ex.Message}", "Error");
            }
        }

        private void ParseButton_Click(object? sender, EventArgs e)
        {
            if (enumsListBox.SelectedItem == null ||
                !enumsListBox.SelectedItem.ToString().Equals(nameof(Weekday)) ||
                string.IsNullOrEmpty(parseInputTextBox.Text))
            {
                resultLabel.Text = "Please select Weekday and enter a value";
                resultLabel.BackColor = System.Drawing.Color.LightPink;
                return;
            }

            try
            {
                if (Enum.TryParse(typeof(Weekday), parseInputTextBox.Text, true, out var result))
                {
                    resultLabel.Text = $"Это день недели ({result} = {(int)result})";
                    resultLabel.BackColor = System.Drawing.Color.LightGreen;
                }
                else
                {
                    resultLabel.Text = "Нет такого дня недели";
                    resultLabel.BackColor = System.Drawing.Color.LightPink;
                }
            }
            catch (Exception ex)
            {
                resultLabel.Text = "Invalid value";
                resultLabel.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show($"Error parsing weekday: {ex.Message}", "Error");
            }
        }

        private void GoButton_Click(object? sender, EventArgs e)
        {
            if (seasonComboBox.SelectedItem == null) return;

            try
            {
                switch (seasonComboBox.SelectedItem.ToString())
                {
                    case "Summer":
                        MessageBox.Show("Ура! Солнце!", "Season");
                        break;
                    case "Autumn":
                        BackColor = System.Drawing.Color.FromArgb(226, 156, 69);
                        break;
                    case "Winter":
                        MessageBox.Show("Бррр! Холодно!", "Season");
                        break;
                    case "Spring":
                        BackColor = System.Drawing.Color.FromArgb(85, 156, 69);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing season: {ex.Message}", "Error");
            }
        }

        private void InitializeClassesTab()
        {
            InitializeMovies();
            InitializeRings();

            moviesListBox.SelectedIndexChanged += MoviesListBox_SelectedIndexChanged;
            ringsListBox.SelectedIndexChanged += RingsListBox_SelectedIndexChanged;
            findMovieButton.Click += FindMovieButton_Click;
            findRingButton.Click += FindRingButton_Click;

            durationTextBox.TextChanged += MovieTextBox_TextChanged;
            yearTextBox.TextChanged += MovieTextBox_TextChanged;
            ratingTextBox.TextChanged += MovieTextBox_TextChanged;

            outerRadiusTextBox.TextChanged += RingTextBox_TextChanged;
            innerRadiusTextBox.TextChanged += RingTextBox_TextChanged;
            ringCenterXTextBox.TextChanged += RingTextBox_TextChanged;
            ringCenterYTextBox.TextChanged += RingTextBox_TextChanged;
        }

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

        private void InitializeRings()
        {
            Random random = new Random();
            for (int i = 0; i < _rings.Length; i++)
            {
                double outerRadius = random.Next(5, 15) + random.NextDouble();
                double innerRadius = random.Next(1, (int)outerRadius - 1) + random.NextDouble();
                var center = new Point2D(
                    random.Next(20, 100) + random.NextDouble(),
                    random.Next(20, 100) + random.NextDouble());

                _rings[i] = new Ring(
                    _nextRingId++,
                    outerRadius,
                    innerRadius,
                    center);

                ringsListBox.Items.Add($"Ring {i + 1}");
            }
            ringsListBox.SelectedIndex = 0;
        }

        private void MoviesListBox_SelectedIndexChanged(object? sender, EventArgs e)
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

        private void FindMovieButton_Click(object? sender, EventArgs e)
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

        private void RingsListBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (ringsListBox.SelectedIndex == -1) return;

            try
            {
                _currentRing = _rings[ringsListBox.SelectedIndex];
                outerRadiusTextBox.Text = _currentRing.OuterRadius.ToString("F1");
                innerRadiusTextBox.Text = _currentRing.InnerRadius.ToString("F1");
                ringCenterXTextBox.Text = _currentRing.Center.X.ToString("F1");
                ringCenterYTextBox.Text = _currentRing.Center.Y.ToString("F1");
                ringIdTextBox.Text = _currentRing.Id.ToString();

                outerRadiusTextBox.BackColor = System.Drawing.Color.White;
                innerRadiusTextBox.BackColor = System.Drawing.Color.White;
                ringCenterXTextBox.BackColor = System.Drawing.Color.White;
                ringCenterYTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading ring: {ex.Message}", "Error");
            }
        }

        private void RingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRing == null) return;

            var textBox = (TextBox)sender;
            try
            {
                if (string.IsNullOrWhiteSpace(textBox.Text)) return;

                if (sender == outerRadiusTextBox)
                {
                    _currentRing.OuterRadius = Validator.AssertOnPositiveValue(
                        double.Parse(outerRadiusTextBox.Text), "Outer Radius");
                }
                else if (sender == innerRadiusTextBox)
                {
                    double outerRadius = _currentRing.OuterRadius;
                    double innerRadius = double.Parse(innerRadiusTextBox.Text);
                    if (innerRadius >= outerRadius)
                    {
                        throw new ArgumentException("Inner radius must be less than outer radius");
                    }
                    _currentRing.InnerRadius = Validator.AssertOnPositiveValue(
                        innerRadius, "Inner Radius");
                }
                else if (sender == ringCenterXTextBox)
                {
                    _currentRing.Center.X = double.Parse(ringCenterXTextBox.Text);
                }
                else if (sender == ringCenterYTextBox)
                {
                    _currentRing.Center.Y = double.Parse(ringCenterYTextBox.Text);
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

        private void FindRingButton_Click(object? sender, EventArgs e)
        {
            if (_rings.Length == 0) return;

            try
            {
                Ring maxAreaRing = _rings[0];
                foreach (var ring in _rings)
                {
                    if (ring.Area > maxAreaRing.Area)
                    {
                        maxAreaRing = ring;
                    }
                }

                ringsListBox.SelectedIndex = Array.IndexOf(_rings, maxAreaRing);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error finding ring: {ex.Message}", "Error");
            }
        }

        private void InitializeRectanglesTab()
        {
            rectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            addRectangleButton.Click += AddRectangleButton_Click;
            removeRectangleButton.Click += RemoveRectangleButton_Click;

            lengthTextBox.TextChanged += RectangleParameter_TextChanged;
            widthTextBox.TextChanged += RectangleParameter_TextChanged;
            centerXTextBox.TextChanged += RectangleParameter_TextChanged;
            centerYTextBox.TextChanged += RectangleParameter_TextChanged;
        }

        private void AddRectangleButton_Click(object? sender, EventArgs e)
        {
            try
            {
                var rectangle = RectangleFactory.Randomize(canvasPanel.Width, canvasPanel.Height);
                _rectangles.Add(rectangle);
                UpdateRectanglesList();

                var panel = new Panel
                {
                    Width = (int)rectangle.Width,
                    Height = (int)rectangle.Length,
                    Location = new Point(
                        (int)(rectangle.Center.X - rectangle.Width / 2),
                        (int)(rectangle.Center.Y - rectangle.Length / 2)),
                    BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127),
                    Tag = rectangle
                };

                _rectanglePanels.Add(panel);
                canvasPanel.Controls.Add(panel);
                FindCollisions();
                UpdateCollisionTabRectangles();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding rectangle: {ex.Message}", "Error");
            }
        }

        private void UpdateRectanglesList()
        {
            rectanglesListBox.Items.Clear();
            foreach (var rectangle in _rectangles)
            {
                rectanglesListBox.Items.Add($"Rectangle {_rectangles.IndexOf(rectangle) + 1} (W: {rectangle.Width:F1}, L: {rectangle.Length:F1})");
            }
        }

        private void RemoveRectangleButton_Click(object? sender, EventArgs e)
        {
            if (rectanglesListBox.SelectedIndex == -1) return;

            try
            {
                int index = rectanglesListBox.SelectedIndex;
                _rectangles.RemoveAt(index);
                canvasPanel.Controls.Remove(_rectanglePanels[index]);
                _rectanglePanels.RemoveAt(index);

                UpdateRectanglesList();
                FindCollisions();
                ClearRectangleInfo();
                UpdateCollisionTabRectangles();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing rectangle: {ex.Message}", "Error");
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (rectanglesListBox.SelectedIndex == -1)
            {
                _currentRectangle = null;
                ClearRectangleInfo();
                return;
            }

            try
            {
                _currentRectangle = _rectangles[rectanglesListBox.SelectedIndex];
                lengthTextBox.Text = _currentRectangle.Length.ToString("F1");
                widthTextBox.Text = _currentRectangle.Width.ToString("F1");
                idTextBox.Text = _currentRectangle.Id.ToString();
                centerXTextBox.Text = _currentRectangle.Center.X.ToString("F1");
                centerYTextBox.Text = _currentRectangle.Center.Y.ToString("F1");

                lengthTextBox.BackColor = System.Drawing.Color.White;
                widthTextBox.BackColor = System.Drawing.Color.White;
                centerXTextBox.BackColor = System.Drawing.Color.White;
                centerYTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading rectangle: {ex.Message}", "Error");
            }
        }

        private void ClearRectangleInfo()
        {
            lengthTextBox.Clear();
            widthTextBox.Clear();
            idTextBox.Clear();
            centerXTextBox.Clear();
            centerYTextBox.Clear();
        }

        private void RectangleParameter_TextChanged(object? sender, EventArgs e)
        {
            if (_currentRectangle == null || sender == null) return;

            var textBox = (TextBox)sender;
            try
            {
                if (string.IsNullOrWhiteSpace(textBox.Text)) return;

                double value = double.Parse(textBox.Text);

                if (sender == lengthTextBox)
                {
                    _currentRectangle.Length = Validator.AssertOnPositiveValue(value, "Length");
                }
                else if (sender == widthTextBox)
                {
                    _currentRectangle.Width = Validator.AssertOnPositiveValue(value, "Width");
                }
                else if (sender == centerXTextBox)
                {
                    _currentRectangle.Center.X = value;
                }
                else if (sender == centerYTextBox)
                {
                    _currentRectangle.Center.Y = value;
                }

                textBox.BackColor = System.Drawing.Color.White;

                int index = _rectangles.IndexOf(_currentRectangle);
                if (index != -1)
                {
                    var panel = _rectanglePanels[index];
                    panel.Width = (int)_currentRectangle.Width;
                    panel.Height = (int)_currentRectangle.Length;
                    panel.Location = new Point(
                        (int)(_currentRectangle.Center.X - _currentRectangle.Width / 2),
                        (int)(_currentRectangle.Center.Y - _currentRectangle.Length / 2));

                    rectanglesListBox.Items[index] = $"Rectangle {index + 1} (W: {_currentRectangle.Width:F1}, L: {_currentRectangle.Length:F1})";
                    FindCollisions();
                }
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

        private void FindCollisions()
        {
            try
            {
                foreach (var panel in _rectanglePanels)
                {
                    panel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
                }

                for (int i = 0; i < _rectangles.Count; i++)
                {
                    for (int j = i + 1; j < _rectangles.Count; j++)
                    {
                        if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                        {
                            _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                            _rectanglePanels[j].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error finding collisions: {ex.Message}", "Error");
            }
        }

        private void InitializeCollisionTab()
        {
            UpdateCollisionTabRectangles();

            for (int i = 0; i < _rings.Length; i++)
            {
                ring1ComboBox.Items.Add($"Ring {i + 1}");
                ring2ComboBox.Items.Add($"Ring {i + 1}");
            }

            if (ring1ComboBox.Items.Count > 0) ring1ComboBox.SelectedIndex = 0;
            if (ring2ComboBox.Items.Count > 1) ring2ComboBox.SelectedIndex = 1;

            checkCollisionButton.Click += CheckCollisionButton_Click;
        }

        private void UpdateCollisionTabRectangles()
        {
            rectangle1ComboBox.Items.Clear();
            rectangle2ComboBox.Items.Clear();

            for (int i = 0; i < _rectangles.Count; i++)
            {
                string item = $"Rectangle {i + 1} (W: {_rectangles[i].Width:F1}, L: {_rectangles[i].Length:F1})";
                rectangle1ComboBox.Items.Add(item);
                rectangle2ComboBox.Items.Add(item);
            }

            if (rectangle1ComboBox.Items.Count > 0) rectangle1ComboBox.SelectedIndex = 0;
            if (rectangle2ComboBox.Items.Count > 1) rectangle2ComboBox.SelectedIndex = 1;
        }

        private void CheckCollisionButton_Click(object? sender, EventArgs e)
        {
            try
            {
                collisionResultLabel.Text = "";
                bool hasCollision = false;

                if (rectangle1ComboBox.SelectedIndex != -1 &&
                    rectangle2ComboBox.SelectedIndex != -1 &&
                    rectangle1ComboBox.SelectedIndex < _rectangles.Count &&
                    rectangle2ComboBox.SelectedIndex < _rectangles.Count)
                {
                    var rect1 = _rectangles[rectangle1ComboBox.SelectedIndex];
                    var rect2 = _rectangles[rectangle2ComboBox.SelectedIndex];
                    hasCollision = CollisionManager.IsCollision(rect1, rect2);
                    collisionResultLabel.Text = $"Rectangles: {(hasCollision ? "COLLISION" : "NO COLLISION")}";
                }

                if (ring1ComboBox.SelectedIndex != -1 &&
                    ring2ComboBox.SelectedIndex != -1 &&
                    ring1ComboBox.SelectedIndex < _rings.Length &&
                    ring2ComboBox.SelectedIndex < _rings.Length)
                {
                    var ring1 = _rings[ring1ComboBox.SelectedIndex];
                    var ring2 = _rings[ring2ComboBox.SelectedIndex];
                    bool ringCollision = CollisionManager.IsCollision(ring1, ring2);

                    if (!string.IsNullOrEmpty(collisionResultLabel.Text))
                        collisionResultLabel.Text += Environment.NewLine;

                    collisionResultLabel.Text += $"Rings: {(ringCollision ? "COLLISION" : "NO COLLISION")}";
                    hasCollision |= ringCollision;
                }

                collisionResultLabel.BackColor = hasCollision ? System.Drawing.Color.LightGreen : System.Drawing.Color.LightPink;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking collision: {ex.Message}", "Error");
            }
        }
    }
}