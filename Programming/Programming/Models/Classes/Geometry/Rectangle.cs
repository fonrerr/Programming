namespace Programming.Models.Classes.Geometry
{

    /// <summary>
    /// Хранит данные о прямоугольнике.
    /// </summary>
    public class Rectangle
    {

        /// <summary>
        /// Хранит значение идентификатора.
        /// </summary>
        private int _id;

        /// <summary>
        /// Хранит значение ширины.
        /// </summary>
        private double _width;

        /// <summary>
        /// Хранит значение высоты.
        /// </summary>
        private double _height;

        /// <summary>
        /// Хранит значение количества созданных прямоугольников.
        /// </summary>
        private static int _allRectanglesCount;

        /// <summary>
        /// Возвращает и задает имя прямоугольника.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задает цвет прямоугольника.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Возвращает количество созданных прямоугольников.
        /// </summary>
        public static int AllRectanglesCount { get { return _allRectanglesCount; } }

        /// <summary>
        /// Возвращает идентификатор.
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// Возвращает и задает ширину прямоугольника. Должна быть больше нуля.
        /// </summary>
        public double Width
        {
            get { return _width; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }

        /// <summary>
        /// Возвращает и задает высоту прямоугольника. Должна быть больше нуля.
        /// </summary>
        public double Height
        {
            get { return _height; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Height));
                _height = value;
            }
        }

        /// <summary>
        /// Возвращает и задает координаты прямоугольника.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Создает экземпляр класса Rectangle.
        /// </summary>
        /// <param name="width">Ширина. Должна быть больше нуля.</param>
        /// <param name="height">Высота. Должны быть больше нуля.</param>
        /// <param name="color">Цвет.</param>
        /// <param name="coordinates">Координаты.</param>
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

        /// <summary>
        /// Создает экземпляр класса Rectangle.
        /// </summary>
        public Rectangle()
        {
        }

        /// <summary>
        /// Возвращает индекс прямоугольника с самой большой шириной. 
        /// </summary>
        /// <returns>Индекс.</returns>
        public int FindRectangleWithMaxWidth()
        {
            return (int)Width;
        }
    }
}
