namespace Programming.Models.Classes
{
    public class Rectangle
    {
        private int _id;
        private double _width;
        private double _lenght;
        private static int _allRectanglesCount;

        //TODO: пустые строки
        public string Name { get; set; }

        public string Color { get; set; }

        public static int AllRectanglesCount { get { return _allRectanglesCount; } }

        public int Id { get { return _id; } }

        public double Width
        {
            get { return _width; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }

        public double Lenght
        {
            get { return _lenght; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Lenght));
                _lenght = value;
            }
        }

        public Point2D Center { get; private set; }

        public Rectangle(double width, double lenght, string color)
        {
            Color = color;
            Width= width;
            Lenght= lenght;
            double centerX = width / 2.0;
            double centerY = lenght / 2.0;
            Center = new Point2D(centerX, centerY);
            _allRectanglesCount++;
            _id = AllRectanglesCount;
        }

        public Rectangle() 
        {
        }

        public string[] GetRectangle()
        {
            string[] rect = { Name, Width.ToString(), Lenght.ToString(), Color };
            return rect;
        }

        public int FindRectangleWithMaxWidth()
        {
            return (int)Width;
        }
    }
}
