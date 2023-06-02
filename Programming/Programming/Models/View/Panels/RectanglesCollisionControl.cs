using Programming.Models.Classes.Geometry;
using Programming.Models.Classes;
using Rectangle = Programming.Models.Classes.Geometry.Rectangle;

namespace Programming.Models.View.Panels
{
    public partial class RectanglesCollisionControl : UserControl
    {
        private List<Rectangle> _rectanglesList = new List<Rectangle>();
        private Rectangle _currentRectangleFromList;
        private List<Panel> _rectanglePanel = new List<Panel>();

        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }

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

        private static string TakeInfoFromRectangle(Rectangle rectangle)
        {
            var info = $"{rectangle.Id}. " +
                       $"(X={rectangle.Center.X}; " +
                       $"Y={rectangle.Center.Y};" +
                       $" W={rectangle.Width}; " +
                       $"L={rectangle.Height})";

            return info;
        }

        private void UpdateRectangleInfo(ref Rectangle rectangle)
        {
            rectangle = _rectanglesList[RectanglesListBox.SelectedIndex];

            IddTextBox.Text = rectangle.Id.ToString();
            XTextBox.Text = rectangle.Center.X.ToString();
            YTextBox.Text = rectangle.Center.Y.ToString();
            WhTextBox.Text = rectangle.Width.ToString();
            HeightTextBox.Text = rectangle.Height.ToString();
        }

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
