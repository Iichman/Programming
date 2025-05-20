namespace Programming.Model
{
    /// <summary>
    /// ������������ ������ � ������� � ���������� ���������, ������� � ���������� ���������������.
    /// </summary>
    public class Ring
    {
        private double _outerRadius;
        private double _innerRadius;
        private Point2D _center;

        /// <summary>
        /// ���������� ������������� ������.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// �������������� ����� ��������� ������ <see cref="Ring"/>.
        /// </summary>
        /// <param name="id">���������� ������������� ������.</param>
        /// <param name="outerRadius">������� ������. ������ ���� ������������� � ������ ����������� �������.</param>
        /// <param name="innerRadius">���������� ������. ������ ���� ������������� � ������ �������� �������.</param>
        /// <param name="center">����� ������. �� ����� ���� null.</param>
        /// <exception cref="ArgumentNullException">�������������, ���� center ����� null.</exception>
        /// <exception cref="ArgumentException">�������������, ���� ������� �� ������������� �����������.</exception>
        public Ring(int id, double outerRadius, double innerRadius, Point2D center)
        {
            Id = id;
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            Center = center ?? throw new ArgumentNullException(nameof(center));
        }

        /// <summary>
        /// ������� ������ ������. ������ ���� ������ ����������� �������.
        /// </summary>
        /// <exception cref="ArgumentException">�������������, ���� �������� �� ������������� ��� ������ ����������� �������.</exception>
        public double OuterRadius
        {
            get => _outerRadius;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(OuterRadius));
                if (value <= InnerRadius)
                {
                    throw new ArgumentException("Outer radius must be greater than inner radius.");
                }
                _outerRadius = value;
            }
        }

        /// <summary>
        /// ���������� ������ ������. ������ ���� ������ �������� �������.
        /// </summary>
        /// <exception cref="ArgumentException">�������������, ���� �������� �� ������������� ��� ������ �������� �������.</exception>
        public double InnerRadius
        {
            get => _innerRadius;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(InnerRadius));
                if (value >= OuterRadius)
                {
                    throw new ArgumentException("Inner radius must be less than outer radius.");
                }
                _innerRadius = value;
            }
        }

        /// <summary>
        /// ����� ������. �� ����� ���� null.
        /// </summary>
        /// <exception cref="ArgumentNullException">�������������, ���� �������� ����� null.</exception>
        public Point2D Center
        {
            get => _center;
            set => _center = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// ������� ������, ����������� ��� �������� �������� �������� � ����������� ������.
        /// </summary>
        public double Area => Math.PI * (Math.Pow(OuterRadius, 2) - Math.Pow(InnerRadius, 2));
    }
}