namespace Programming.Models.Classes
{
    public class Rectangle
    {
        public double _width;
        public double _lenght;
        public string Name { get; set; }
        public string Color { get; set; }

        public double Width
        {
            get { return _width; }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    throw new ArgumentException($"{Width} не является подходящим числом");
                }
            }
        }

        public double Lenght
        {
            get { return _lenght; }
            set
            {
                if (value > 0)
                {
                    _lenght = value;
                }
                else
                {
                    throw new ArgumentException($"{Lenght} не является подходящим числом");
                }
            }
        }

        public Rectangle(double width, double lenght, string color)
        {
            Color = color;
            Width= width;
            Lenght= lenght;
        }
        public Rectangle() 
        {
        }

        public string[] GetRectangle()
        {
            string[] answ = { Name, Width.ToString(), Lenght.ToString(), Color };
            return answ;
        }

        public int FindRectangleWithMaxWidth()
        {
            return (int)Width;
        }
    }
}
