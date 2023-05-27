namespace Programming.Models.Classes.Geometry
{
    public class Ring
    {
        private double _innerRadius;
        private double _outerRadius;
        private Point2D _center;

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

        public Point2D Center
        {
            get => _center;
            private set => _center = value;
        }

        public double Area
        {
            get
            {
                double outerCircleArea = Math.PI * Math.Pow(OuterRadius, 2);
                double innerCircleArea = Math.PI * Math.Pow(InnerRadius, 2);
                return outerCircleArea - innerCircleArea;
            }
        }

        public Ring(double innerRadius, double outerRadius, Point2D center)
        {
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            Center = center;
        }
    }
}
