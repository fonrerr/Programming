namespace Programming.Models.Classes.Geometry
{
    public class Rectangle
    {
        private int _id;
        private double _width;
        private double _height;
        private static int _allRectanglesCount;

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

        public double Height
        {
            get { return _height; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Height));
                _height = value;
            }
        }

        public Point2D Center { get; set; }

        public Rectangle(double width, double height, string color, Point2D coordinates)
        {
            Color = color;
            Width = width;
            Height = height;
            double centerX = width / 2.0;
            double centerY = height / 2.0;
            Center = coordinates; 
            _allRectanglesCount++;
            _id = AllRectanglesCount;
        }

        public Rectangle()
        {
        }

        public string[] GetRectangle()
        {
            string[] rect = { Name, Width.ToString(), Height.ToString(), Color };
            return rect;
        }

        public int FindRectangleWithMaxWidth()
        {
            return (int)Width;
        }
    }
}
