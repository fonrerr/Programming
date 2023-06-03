namespace Programming.Models.Classes.Geometry
{
    /// <summary>
    /// Хранит данные о кольце.
    /// </summary>
    public class Ring
    {
        /// <summary>
        /// Хранит значение внутреннего радиуса.
        /// </summary>
        private double _innerRadius;

        /// <summary>
        /// Хранит значение внешнего радиуса.
        /// </summary>
        private double _outerRadius;

        /// <summary>
        /// Хранит значение центра.
        /// </summary>
        private Point2D _center;

        /// <summary>
        /// Возвращает и задает внутренний радиус. Должен быть меньше внешнего и быть положительным числом.
        /// </summary>
        public double InnerRadius
        {
            get { return _innerRadius; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(InnerRadius));

                if (value >= OuterRadius)
                {
                    throw new ArgumentException("Внутренний радиус должен быть меньше внешнего радиуса.");
                }
                _innerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает и задает внешний радиус. Должен быть меньше внешнего и быть положительным числом.
        /// </summary>
        public double OuterRadius
        {
            get => _outerRadius;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(OuterRadius));

                if (value <= InnerRadius)
                {
                    throw new ArgumentException("Внешний радиус должен быть больше внутреннего радиуса.");
                }
                _outerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает и задает координаты кольца внутри класса.
        /// </summary>
        public Point2D Center
        {
            get => _center;
            private set => _center = value;
        }

        /// <summary>
        /// Возвращает площадь кольца.
        /// </summary>
        public double Area
        {
            get
            {
                double outerCircleArea = Math.PI * Math.Pow(OuterRadius, 2);
                double innerCircleArea = Math.PI * Math.Pow(InnerRadius, 2);
                return outerCircleArea - innerCircleArea;
            }
        }

        /// <summary>
        /// Создает экземпляр класса Ring.
        /// </summary>
        /// <param name="innerRadius">Внешний радиус. Должен быть больше внутреннего и быть положительным числом.</param>
        /// <param name="outerRadius">Внутренний радиус. Должен быть меньше внешнего и быть положительным числом.</param>
        /// <param name="center"></param>
        public Ring(double innerRadius, double outerRadius, Point2D center)
        {
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            Center = center;
        }
    }
}
