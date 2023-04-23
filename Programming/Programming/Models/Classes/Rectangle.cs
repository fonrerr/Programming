namespace Programming.Models.Classes
{
    internal class Rectangle
    {
        private double _width;
        private double _lenght;
        public string Name { get; set; }

        public string Color { get; set; }

        public double Width
        {
            get { return _width; }
            set
            {
                if (value > 0.0d)
                {
                    _width = value;
                }
                else
                {
                    throw new ArgumentException(String.Format("{0} не является подходящим числом", _width), "width");
                }
            }
        }
        public double Lenght
        {
            get { return _lenght; }
            set
            {
                if (value > 0.0d) 
                {
                    _lenght = value;
                }
                else
                {
                    throw new ArgumentException(String.Format("{0} не является подходящим числом", _lenght), "lenght");
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

        public string[] answRec()
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
