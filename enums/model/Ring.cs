namespace Programming.Model
{
    public class Ring
    {
        private double _outerRadius;
        private double _innerRadius;
        private Point2D _center;

        public int Id { get; }

        public Ring(int id, double outerRadius, double innerRadius, Point2D center)
        {
            Id = id;
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            Center = center ?? throw new ArgumentNullException(nameof(center));
        }

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

        public Point2D Center
        {
            get => _center;
            set => _center = value ?? throw new ArgumentNullException(nameof(value));
        }

        public double Area => Math.PI * (Math.Pow(OuterRadius, 2) - Math.Pow(InnerRadius, 2));
    }
}