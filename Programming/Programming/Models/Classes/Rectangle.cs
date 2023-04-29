namespace Programming.Models.Classes
{
    internal class Rectangle
    {
        private double _width;
        private double _lenght;
        public string Name { get; set; }
        private double _height;
        public string Color { get; set; }
        private int _id;
        private static int _allRectanglesCount = 0;
        public double Height
        {
            get { return _height; }
            set
            {
                Validator.AssertOnPositiveValue(value);
            }
        }
        public int Id
        {
            get { return _id; }
            set
            {
                Validator.AssertOnPositiveValue(value);
            }
        }
        public double Width
        {
            get { return _width; }
            set
            {
                Validator.AssertOnPositiveValue(value);
            }
        }
        public double Lenght
        {
            get { return _lenght; }
            set
            {
                Validator.AssertOnPositiveValue(value);
            }
        }

        public Rectangle(double width, double lenght, string color, int id)
        {
            Color = color;
            Width= width;
            Lenght= lenght;
            Id = id;
        }
        public Rectangle() 
        {
            _allRectanglesCount += 1;
        }

        public string[] answRec()
        {
            string[] answ = { Name, Width.ToString(), Lenght.ToString(), Color };
            return answ;
        }

        public int FindRectangleWithMaxWidth()
        {

            return (int)Width;
        }
        public Point2D Center()
        {
            int x_center = (int)Width / 2;
            int y_center = (int)Height / 2;
        }
    }
}
