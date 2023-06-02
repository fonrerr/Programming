using Programming.Models.Classes.Geometry;
using Programming.Models.Classes;
using Rectangle = Programming.Models.Classes.Geometry.Rectangle;

namespace Programming.Models.View.Panels
{
    /// <summary>
    /// Предоставляет шаблон пользовательского интерфейса RectanglesCollisionControl.
    /// </summary>
    public partial class RectanglesCollisionControl : UserControl
    {
        /// <summary>
        /// Список прямоугольников.
        /// </summary>
        private List<Rectangle> _rectanglesList = new List<Rectangle>();

        /// <summary>
        /// Текущий выбранный прямоугольник.
        /// </summary>
        private Rectangle _currentRectangleFromList;

        /// <summary>
        /// Список панелей прямоугольника.
        /// </summary>
        private List<Panel> _rectanglePanel = new List<Panel>();

        /// <summary>
        /// Создает экземпляр класса RectanglesCollisionControl.
        /// </summary>
        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Добавление нового прямоугольника.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            Random _random = new Random();
            var rectangle = RectangleFactory.Randomize();
            var panel = new Panel();

            var info = TakeInfoFromRectangle(rectangle);

            _rectanglesList.Add(rectangle);
            RectanglesListBox.Items.Add(info);

            panel.Height = Convert.ToInt32(rectangle.Height);
            panel.Width = Convert.ToInt32(rectangle.Width);
            var x = Convert.ToInt32(rectangle.Center.X);
            var y = Convert.ToInt32(rectangle.Center.Y);
            panel.Location = new Point(x, y);
            panel.BackColor = AppColors.CollisionFalse;

            _rectanglePanel.Add(panel);
            RectanglesPanel.Controls.Add(panel);
            FindCollision();
        }

        /// <summary>
        /// Возвращает строку с данными о прямоугольнике.
        /// </summary>
        /// <param name="rectangle">Прямоугольник.</param>
        /// <returns>Строка с данными о прямоугольнике.</returns>
        private static string TakeInfoFromRectangle(Rectangle rectangle)
        {
            var info = $"{rectangle.Id}. " +
                       $"(X={rectangle.Center.X}; " +
                       $"Y={rectangle.Center.Y};" +
                       $" W={rectangle.Width}; " +
                       $"L={rectangle.Height})";

            return info;
        }

        /// <summary>
        /// Обновление данных в TextBox.
        /// </summary>
        /// <param name="rectangle">Прямоугольник.</param>
        private void UpdateRectangleInfo(ref Rectangle rectangle)
        {
            rectangle = _rectanglesList[RectanglesListBox.SelectedIndex];

            IddTextBox.Text = rectangle.Id.ToString();
            XTextBox.Text = rectangle.Center.X.ToString();
            YTextBox.Text = rectangle.Center.Y.ToString();
            WhTextBox.Text = rectangle.Width.ToString();
            HeightTextBox.Text = rectangle.Height.ToString();
        }

        /// <summary>
        /// Очистка данных в TextBox.
        /// </summary>
        private void ClearRectangleInfo()
        {
            IddTextBox.Text = string.Empty;
            XTextBox.Text = string.Empty;
            YTextBox.Text = string.Empty;
            WhTextBox.Text = string.Empty;
            HeightTextBox.Text = string.Empty;

            XTextBox.BackColor = AppColors.NormalColor;
            YTextBox.BackColor = AppColors.NormalColor;
            WhTextBox.BackColor = AppColors.NormalColor;
            HeightTextBox.BackColor = AppColors.NormalColor;
        }

        /// <summary>
        /// Выбор элемента в RectanglesListBox с последующим обновлением информации в TextBox.
        /// </summary>
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateRectangleInfo(ref _currentRectangleFromList);
            }
            catch
            {
                ClearRectangleInfo();
            }
        }

        /// <summary>
        /// Изменения данных в XTextBox.
        /// </summary>
        private void XTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                XTextBox.BackColor = AppColors.NormalColor;
                var x = Convert.ToDouble(XTextBox.Text);
                var y = _currentRectangleFromList.Center.Y;
                var coordinatePoint2D = new Point2D(x, y);
                var coordinatePoint = new Point(Convert.ToInt32(x), Convert.ToInt32(y));
                var info = TakeInfoFromRectangle(_currentRectangleFromList);

                _currentRectangleFromList.Center = coordinatePoint2D;
                _rectanglePanel[RectanglesListBox.SelectedIndex].Location = coordinatePoint;
                RectanglesListBox.Items[RectanglesListBox.SelectedIndex] = info;
                FindCollision();
            }
            catch
            {
                XTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        /// <summary>
        /// Проверка на пересечение прямоугольников. В случаи пересечения, прямоугольники меняют свой цвет.
        /// </summary>
        private void FindCollision()
        {
            foreach (Panel rectangle in RectanglesPanel.Controls)
            {
                rectangle.BackColor = AppColors.CollisionFalse;
            }

            for (int i = 0; i < _rectanglesList.Count; i++)
            {
                _rectanglePanel[i].BackColor = AppColors.CollisionFalse;
            }

            for (int i = 0; i < _rectanglesList.Count; i++)
            {
                for (int j = 0; j < _rectanglesList.Count; j++)
                {
                    if (i != j)
                    {
                        if (CollisionManager.IsCollision(_rectanglesList[i], _rectanglesList[j]))
                        {
                            _rectanglePanel[i].BackColor = AppColors.CollisionTrue;
                            _rectanglePanel[j].BackColor = AppColors.CollisionTrue;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Изменения данных в YTextBox.
        /// </summary>
        private void YTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                YTextBox.BackColor = AppColors.NormalColor;

                var y = Convert.ToDouble(YTextBox.Text);
                var x = _currentRectangleFromList.Center.X;
                var coordinatePoint2D = new Point2D(x, y);
                var coordinatePoint = new Point(Convert.ToInt32(x), Convert.ToInt32(y));
                var info = TakeInfoFromRectangle(_currentRectangleFromList);

                _currentRectangleFromList.Center = coordinatePoint2D;
                _rectanglePanel[RectanglesListBox.SelectedIndex].Location = coordinatePoint;
                RectanglesListBox.Items[RectanglesListBox.SelectedIndex] = info;
                FindCollision();
            }
            catch
            {
                YTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        /// <summary>
        /// Изменения данных в WhTextBox.
        /// </summary>
        private void WhTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                WhTextBox.BackColor = AppColors.NormalColor;
                var widthDouble = Convert.ToDouble(WhTextBox.Text);
                var widthInt = Convert.ToInt32(WhTextBox.Text);
                var info = TakeInfoFromRectangle(_currentRectangleFromList);

                _currentRectangleFromList.Width = widthDouble;
                _rectanglePanel[RectanglesListBox.SelectedIndex].Width = widthInt;
                RectanglesListBox.Items[RectanglesListBox.SelectedIndex] = info;
                FindCollision();
            }
            catch
            {
                WhTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        /// <summary>
        /// Изменение данных в HeightTextBox.
        /// </summary>
        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                HeightTextBox.BackColor = AppColors.NormalColor;
                var heightDouble = Convert.ToDouble(HeightTextBox.Text);
                var heightInt = Convert.ToInt32(HeightTextBox.Text);
                var info = TakeInfoFromRectangle(_currentRectangleFromList);

                _currentRectangleFromList.Height = heightDouble;
                _rectanglePanel[RectanglesListBox.SelectedIndex].Height = heightInt;
                RectanglesListBox.Items[RectanglesListBox.SelectedIndex] = info;
                FindCollision();
            }
            catch
            {
                HeightTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        /// <summary>
        /// Удаление выбранного прямоугольника.
        /// </summary>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                _rectanglesList.RemoveAt(RectanglesListBox.SelectedIndex);
                _rectanglePanel.RemoveAt(RectanglesListBox.SelectedIndex);
                RectanglesPanel.Controls.RemoveAt(RectanglesListBox.SelectedIndex);
                RectanglesListBox.Items.RemoveAt(RectanglesListBox.SelectedIndex);
                FindCollision();
            }
            catch
            {
                // ignored
            }
        }
    }
}
