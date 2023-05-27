using Programming.Models.Enums;

namespace Programming.Models.Classes.Geometry
{
    public static class RectangleFactory
    {
        private static Random _random = new Random();

        public static Rectangle Randomize()
        {
           // Random _random = new Random();

            var width = _random.Next(30, 100);
            var height = _random.Next(30, 110);

            var x = _random.Next(1, 300);
            var y = _random.Next(1, 300);

            Point2D coordinates = new Point2D(x, y);

            var colorValues = Enum.GetValues(typeof(Colors));
            var color = colorValues.GetValue(_random.Next(0, 6)).ToString();

            return new Rectangle(height, width, color, coordinates);
        }
    }
}
