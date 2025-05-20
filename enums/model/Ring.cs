namespace Programming.Model
{
    /// <summary>
    /// Представляет кольцо с внешним и внутренним радиусами, центром и уникальным идентификатором.
    /// </summary>
    public class Ring
    {
        private double _outerRadius;
        private double _innerRadius;
        private Point2D _center;

        /// <summary>
        /// Уникальный идентификатор кольца.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Ring"/>.
        /// </summary>
        /// <param name="id">Уникальный идентификатор кольца.</param>
        /// <param name="outerRadius">Внешний радиус. Должен быть положительным и больше внутреннего радиуса.</param>
        /// <param name="innerRadius">Внутренний радиус. Должен быть положительным и меньше внешнего радиуса.</param>
        /// <param name="center">Центр кольца. Не может быть null.</param>
        /// <exception cref="ArgumentNullException">Выбрасывается, если center равен null.</exception>
        /// <exception cref="ArgumentException">Выбрасывается, если радиусы не соответствуют требованиям.</exception>
        public Ring(int id, double outerRadius, double innerRadius, Point2D center)
        {
            Id = id;
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            Center = center ?? throw new ArgumentNullException(nameof(center));
        }

        /// <summary>
        /// Внешний радиус кольца. Должен быть больше внутреннего радиуса.
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается, если значение не положительное или меньше внутреннего радиуса.</exception>
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
        /// Внутренний радиус кольца. Должен быть меньше внешнего радиуса.
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается, если значение не положительное или больше внешнего радиуса.</exception>
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
        /// Центр кольца. Не может быть null.
        /// </summary>
        /// <exception cref="ArgumentNullException">Выбрасывается, если значение равно null.</exception>
        public Point2D Center
        {
            get => _center;
            set => _center = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Площадь кольца, вычисляемая как разность площадей внешнего и внутреннего кругов.
        /// </summary>
        public double Area => Math.PI * (Math.Pow(OuterRadius, 2) - Math.Pow(InnerRadius, 2));
    }
}