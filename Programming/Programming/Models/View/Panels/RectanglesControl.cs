using Programming.Models.Classes;
using Programming.Models.Classes.Geometry;
using Rectangle = Programming.Models.Classes.Geometry.Rectangle;

namespace Programming.Models.View.Panels
{

    /// <summary>
    /// Предоставляет шаблон пользовательского интерфейса RectanglesControl.
    /// </summary>
    public partial class RectanglesControl : UserControl
    {
        /// <summary>
        /// Массив прямоугольников.
        /// </summary>
        private Rectangle[] _rectangles = new Rectangle[5];

        /// <summary>
        /// Текущий выбранный прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle = new Rectangle();

        /// <summary>
        /// Переменная для максимума.
        /// </summary>
        private int _max = 0;

        /// <summary>
        /// Массив цветов.
        /// </summary>
        private string[] _colors = { "Orange", "Black", "Red", "Green", "Blue" };

        public RectanglesControl()
        {
            InitializeComponent();
            InitRectangles();
        }

        /// <summary>
        /// Заполнение массива прямоугольников случайными прямоугольниками и случайными параметрами.
        /// </summary>
        private void InitRectangles()
        {
            Random rd = new Random();
            for (int i = 0; i < _rectangles.Length; i++)
            {
                _rectangles[i] = new Rectangle(Convert.ToDouble(rd.Next(1, 244)),
                    Convert.ToDouble(rd.Next(1, 244)), _colors[rd.Next(0, 4)],
                    new Point2D(rd.Next(1, 300), rd.Next(1, 300)));
                RectListBox.Items[i] = ($"Rectangle {i + 1}");
            }
            RectListBox.SetSelected(0, true);
        }

        /// <summary>
        /// Выбор элемента в RectListBox с последующим обновлением информации в TextBox.
        /// </summary>
        private void RectListBox_SelectedIndexChange(object sender, EventArgs e)
        {
            Rectangle answr = _rectangles[RectListBox.SelectedIndex];
            IdTextBox.Text = answr.Id.ToString();
            ColorTextBox.Text = answr.Color.ToString();
            LenghtTextBox.Text = answr.Height.ToString();
            WidthTextBox.Text = answr.Width.ToString();
            XCoordinateTextBox.Text = answr.Center.X.ToString();
            YCoordinateTextBox.Text = answr.Center.Y.ToString();
            _currentRectangle = _rectangles[(int)RectListBox.SelectedIndex];
        }

        /// <summary>
        /// Изменение данных в LenghtTextBox.
        /// </summary>
        private void LenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LenghtTextBox.Text != "" && WidthTextBox.Text != "" && ColorTextBox.Text != "")
            {
                try
                {
                    LenghtTextBox.BackColor = AppColors.NormalColor;
                    _currentRectangle = new Models.Classes.Geometry.Rectangle(
                        Convert.ToInt32(LenghtTextBox.Text),
                        Convert.ToInt32(WidthTextBox.Text), ColorTextBox.Text,
                        new Point2D(Convert.ToInt32(XCoordinateTextBox.Text), Convert.ToInt32(YCoordinateTextBox.Text)));
                    _rectangles[(int)RectListBox.SelectedIndex] = _currentRectangle;
                }
                catch
                {
                    LenghtTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }

        /// <summary>
        /// Обработчик, который выбирает элемент с максимальной шириной.
        /// </summary>
        private void FindButton_Click(object sender, EventArgs e)
        {
            _max = 0;
            int index = 0;
            for (int i = 0; i < _rectangles.Length; i++)
            {
                if (_max < _rectangles[i].FindRectangleWithMaxWidth())
                {
                    _max = _rectangles[i].FindRectangleWithMaxWidth();
                    index = i;

                }
            }
            MessageBox.Show($"Íàèáîëüøèé ïðÿìîóãîëüíèê ñ èíäåêñîì - {index}");
            RectListBox.SetSelected(index, true);
        }

        /// <summary>
        /// Изменение данных в ColorTextBox.
        /// </summary>
        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LenghtTextBox.Text != "" && WidthTextBox.Text != "" && ColorTextBox.Text != "")
            {
                try
                {
                    ColorTextBox.BackColor = Color.White;
                    _currentRectangle = new Models.Classes.Geometry.Rectangle(
                        Convert.ToInt32(LenghtTextBox.Text),
                        Convert.ToInt32(WidthTextBox.Text), ColorTextBox.Text,
                        new Point2D(Convert.ToInt32(XCoordinateTextBox.Text), Convert.ToInt32(YCoordinateTextBox.Text)));
                    _rectangles[(int)RectListBox.SelectedIndex] = _currentRectangle;
                }
                catch
                {
                    ColorTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }

        /// <summary>
        /// Изменение данных в WidthTextBox.
        /// </summary>
        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LenghtTextBox.Text != "" && WidthTextBox.Text != "" && ColorTextBox.Text != "")
            {
                try
                {
                    WidthTextBox.BackColor = Color.White;
                    _currentRectangle = new Models.Classes.Geometry.Rectangle(
                        Convert.ToInt32(LenghtTextBox.Text),
                        Convert.ToInt32(WidthTextBox.Text), ColorTextBox.Text,
                        new Point2D(Convert.ToInt32(XCoordinateTextBox.Text), Convert.ToInt32(YCoordinateTextBox.Text)));
                    _rectangles[(int)RectListBox.SelectedIndex] = _currentRectangle;
                }
                catch
                {
                    WidthTextBox.BackColor = AppColors.ErrorColor;
                }

            }
        }
    }
}
