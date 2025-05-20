using System;
using System.Windows.Forms;
using Programming.Model;

namespace Programming.View.Controls
{
    /// <summary>
    /// ������� ���������� ��� ����������� � ����������� ����������� ����� ���������������� � ��������.
    /// </summary>
    public partial class RectanglesCollisionControl : UserControl
    {
        private RectanglesControl _rectanglesControl;
        private RingsControl _ringsControl;

        /// <summary>
        /// �������������� ����� ��������� ������ <see cref="RectanglesCollisionControl"/>.
        /// </summary>
        /// <param name="rectanglesControl">��������� <see cref="RectanglesControl"/> ��� ���������� ����������������.</param>
        /// <param name="ringsControl">��������� <see cref="RingsControl"/> ��� ���������� ��������.</param>
        /// <exception cref="ArgumentNullException">����������, ���� <paramref name="rectanglesControl"/> ��� <paramref name="ringsControl"/> ����� null.</exception>
        public RectanglesCollisionControl(RectanglesControl rectanglesControl, RingsControl ringsControl)
        {
            InitializeComponent();
            _rectanglesControl = rectanglesControl ?? throw new ArgumentNullException(nameof(rectanglesControl));
            _ringsControl = ringsControl ?? throw new ArgumentNullException(nameof(ringsControl));

            // ������������� �� ������� ��������� ���������������
            _rectanglesControl.RectanglesChanged += (sender, e) => UpdateRectanglesComboBoxes();

            InitializeCollisionTab();
            UpdateRectanglesComboBoxes();
            UpdateRingsComboBoxes();
        }

        /// <summary>
        /// �������������� ������� �������� � ������������� ����������� �������.
        /// </summary>
        private void InitializeCollisionTab()
        {
            checkCollisionButton.Click += CheckCollisionButton_Click;
        }

        /// <summary>
        /// ��������� ���������� ��� ������ ���������������.
        /// </summary>
        private void UpdateRectanglesComboBoxes()
        {
            rectangle1ComboBox.Items.Clear();
            rectangle2ComboBox.Items.Clear();

            var rectangles = _rectanglesControl.GetRectangles();
            for (int i = 0; i < rectangles.Count; i++)
            {
                string item = $"Rectangle {i + 1} (W: {rectangles[i].Width:F1}, L: {rectangles[i].Length:F1})";
                rectangle1ComboBox.Items.Add(item);
                rectangle2ComboBox.Items.Add(item);
            }

            if (rectangle1ComboBox.Items.Count > 0) rectangle1ComboBox.SelectedIndex = 0;
            if (rectangle2ComboBox.Items.Count > 1) rectangle2ComboBox.SelectedIndex = 1;
        }

        /// <summary>
        /// ��������� ���������� ��� ������ �����.
        /// </summary>
        private void UpdateRingsComboBoxes()
        {
            ring1ComboBox.Items.Clear();
            ring2ComboBox.Items.Clear();

            var rings = _ringsControl.GetRings();
            for (int i = 0; i < rings.Length; i++)
            {
                ring1ComboBox.Items.Add($"Ring {i + 1}");
                ring2ComboBox.Items.Add($"Ring {i + 1}");
            }

            if (ring1ComboBox.Items.Count > 0) ring1ComboBox.SelectedIndex = 0;
            if (ring2ComboBox.Items.Count > 1) ring2ComboBox.SelectedIndex = 1;
        }

        /// <summary>
        /// ������������ ������� ������ �������� �������� ����� ���������� ��������.
        /// </summary>
        /// <param name="sender">�������� �������.</param>
        /// <param name="e">������ �������.</param>
        private void CheckCollisionButton_Click(object sender, EventArgs e)
        {
            collisionResultLabel.Text = "";
            bool hasCollision = false;

            // Check rectangle collisions
            if (rectangle1ComboBox.SelectedIndex != -1 &&
                rectangle2ComboBox.SelectedIndex != -1)
            {
                var rectangles = _rectanglesControl.GetRectangles();
                if (rectangle1ComboBox.SelectedIndex < rectangles.Count &&
                    rectangle2ComboBox.SelectedIndex < rectangles.Count)
                {
                    var rect1 = rectangles[rectangle1ComboBox.SelectedIndex];
                    var rect2 = rectangles[rectangle2ComboBox.SelectedIndex];
                    hasCollision = CollisionManager.IsCollision(rect1, rect2);
                    collisionResultLabel.Text = $"Rectangles: {(hasCollision ? "COLLISION" : "NO COLLISION")}";
                }
            }

            // �������� ����������� �����
            if (ring1ComboBox.SelectedIndex != -1 &&
                ring2ComboBox.SelectedIndex != -1)
            {
                var rings = _ringsControl.GetRings();
                if (ring1ComboBox.SelectedIndex < rings.Length &&
                    ring2ComboBox.SelectedIndex < rings.Length)
                {
                    var ring1 = rings[ring1ComboBox.SelectedIndex];
                    var ring2 = rings[ring2ComboBox.SelectedIndex];
                    bool ringCollision = CollisionManager.IsCollision(ring1, ring2);

                    if (!string.IsNullOrEmpty(collisionResultLabel.Text))
                        collisionResultLabel.Text += Environment.NewLine;

                    collisionResultLabel.Text += $"Rings: {(ringCollision ? "COLLISION" : "NO COLLISION")}";
                    hasCollision |= ringCollision;
                }
            }

            collisionResultLabel.BackColor = hasCollision ? System.Drawing.Color.LightGreen : System.Drawing.Color.LightPink;
            _rectanglesControl.FindCollisions();
        }

        /// <summary>
        /// ��������� ������ � ����������� ��� ��������������� � �����.
        /// </summary>
        public void UpdateData()
        {
            UpdateRectanglesComboBoxes();
            UpdateRingsComboBoxes();
        }
    }
}