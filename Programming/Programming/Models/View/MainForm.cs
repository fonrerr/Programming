using Programming.Models.Classes;
using Programming.Models.Classes.Geometry;
using Programming.Models.Enums;
using Rectangle = Programming.Models.Classes.Geometry.Rectangle;

namespace Programming
{
    public partial class MainForm : Form
    {
        //TODO: RSDN
        string[] _enums = { "Colors", "EducationForm", "Genre", "Menufactures", "Season", "Weekday" };
        private Rectangle[] _rectangles;
        private Movie[] _movie;
        private Rectangle _currentRectangle = new Rectangle();
        private Movie _currentMovie = new Movie();
        private string[] _colors = { "Orange", "Black", "Red", "Green", "Blue" };
        private int _max = 0;
        private List<Rectangle> _rectanglesList = new List<Rectangle>();
        //TODO: изменить название
        private Rectangle _currentRectangleFromList;
        private List<Panel> _rectanglePanel = new List<Panel>();
        public MainForm()
        {
            _rectangles = new Rectangle[5];
            _movie = new Movie[5];
            InitializeComponent();
            InitRectanglesAndMovies();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            EnumsListBox.Items.AddRange(_enums);
            EnumsListBox.SetSelected(0, true); 
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueListBox.Items.Clear();
            ListBox listbox = (ListBox)sender; 
            string elem = listbox.SelectedItem as string; 
            switch (elem)
            {
                case "Colors":

                    ValueListBox.Items.AddRange(typeof(Colors).GetEnumNames());
                    break;
                case "EducationForm":
                    ValueListBox.Items.AddRange(typeof(EducationForm).GetEnumNames());
                    break;
                case "Genre":
                    ValueListBox.Items.AddRange(typeof(Genre).GetEnumNames());
                    break;
                case "Season":
                    ValueListBox.Items.AddRange(typeof(Season).GetEnumNames());
                    break;
                case "Menufactures":
                    ValueListBox.Items.AddRange(typeof(Manufactures).GetEnumNames());
                    break;
                case "Weekday":
                    ValueListBox.Items.AddRange(typeof(Weekday).GetEnumNames());
                    break;
            }
        }

        private void ValueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntTextBox.Text = ValueListBox.SelectedIndex.ToString();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            Weekday week;
            if (Enum.TryParse<Weekday>(ParseTextBox.Text, out week)) 
                ParseLabel.Text = $"«Ýòî äåíü íåäåëè ({week} = {((int)week + 1)})»";
            else ParseLabel.Text = "Íåò òàêîãî äíÿ íåäåëè!";
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            string selectedSeason = SeasonComboBox.SelectedItem.ToString();
            switch (selectedSeason)
            {
                case "Winter":
                    MessageBox.Show("Áðð, õîëîäèùà!");
                    break;
                case "Summer":
                    MessageBox.Show("Óðà! Ñîëíöå!");
                    break;
                case "Spring":
                    GroupBox.BackColor = Color.GreenYellow; 
                    break;
                case "Autumn":
                    GroupBox.BackColor = Color.Orange;
                    break;
            }
        }
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
                    ColorTextBox.BackColor = Color.LightPink;
                }
            }
        }
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
                    WidthTextBox.BackColor = Color.LightPink;
                }

            }
        }

        private void RectListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rectangle answr = _rectangles[RectListBox.SelectedIndex];
            IdTextBox.Text = answr.Id.ToString();
            ColorTextBox.Text = answr.Color.ToString();
            LenghtTextBox.Text = answr.Lenght.ToString();
            WidthTextBox.Text = answr.Width.ToString();
            XCoordinateTextBox.Text = answr.Center.X.ToString();
            YCoordinateTextBox.Text = answr.Center.Y.ToString();
            _currentRectangle = _rectangles[(int)RectListBox.SelectedIndex];
        }

        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            _max = 0;
            int index = 0;
            for (int i = 0; i < _movie.Length; i++)
            {
                if (_max < _movie[i].FindMovieWithMaxRating())
                {
                    _max = _movie[i].FindMovieWithMaxRating();
                    index = i;

                }

            }
            MessageBox.Show($"Ñàìûé ðåéòèíãîâûé ôèëüì ñ èíäåêñîì - {index}");
            MovieListBox.SetSelected(index, true);
        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Movie answr = _movie[MovieListBox.SelectedIndex];
            TitleTextBox.Text = answr.Title.ToString();
            DurationTextBox.Text = answr.Duration.ToString();
            YearTextBox.Text = answr.Year.ToString();
            GenreTextBox.Text = answr.Genre.ToString();
            RatingTextBox.Text = answr.Rating.ToString();
            _currentMovie = _movie[(int)MovieListBox.SelectedIndex];
        }
        private void InitRectanglesAndMovies()
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
            var Movie = new[]
            {
                new Movie("Äðàêóëà", 320, 1999, "Óæàñû", 7),
                new Movie("Çîëóøêà", 170, 1989, "Ìóëüòôèëüì", 8),
                new Movie("Çåáðà", 620, 2013, "Íàó÷íûé", 5),
                new Movie("Àâàòàð2", 330, 2023, "Ôàíòàñòèêà", 9),
                new Movie("Ïèíîêèî", 120, 2013, "Ìóëüòôèëüì", 6)
            };
            _movie = Movie.ToArray();
            for (int j = 0; j < _movie.Length; j++)
            {
                MovieListBox.Items[j] = ($"Ôèëüì {j + 1}");
            }

            MovieListBox.SetSelected(0, true);
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            if (DurationTextBox.Text != "" && YearTextBox.Text != "" && RatingTextBox.Text != "" && GenreTextBox.Text != "" && TitleTextBox.Text != "")
            {
                try
                {
                    DurationTextBox.BackColor = Color.White;
                    _currentMovie = new Models.Classes.Movie(
                        TitleTextBox.Text,
                        Convert.ToInt32(DurationTextBox.Text),
                        Convert.ToInt32(YearTextBox.Text),
                        GenreTextBox.Text,
                        Convert.ToInt32(RatingTextBox.Text));
                    _movie[(int)MovieListBox.SelectedIndex] = _currentMovie;
                }
                catch
                {
                    DurationTextBox.BackColor = Color.LightPink;
                }

            }
        }

        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            if (DurationTextBox.Text != "" && YearTextBox.Text != "" && RatingTextBox.Text != "" && GenreTextBox.Text != "" && TitleTextBox.Text != "")
            {
                try
                {
                    YearTextBox.BackColor = Color.White;
                    _currentMovie = new Models.Classes.Movie(
                        TitleTextBox.Text,
                        Convert.ToInt32(DurationTextBox.Text),
                        Convert.ToInt32(YearTextBox.Text),
                        GenreTextBox.Text,
                        Convert.ToInt32(RatingTextBox.Text));
                    _movie[(int)MovieListBox.SelectedIndex] = _currentMovie;
                }
                catch
                {
                    YearTextBox.BackColor = Color.LightPink;
                }

            }
        }

        private void LenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LenghtTextBox.Text != "" && WidthTextBox.Text != "" && ColorTextBox.Text != "")
            {
                try
                {
                    LenghtTextBox.BackColor = Color.White;
                    _currentRectangle = new Models.Classes.Geometry.Rectangle(
                        Convert.ToInt32(LenghtTextBox.Text),
                        Convert.ToInt32(WidthTextBox.Text), ColorTextBox.Text,
                        new Point2D(Convert.ToInt32(XCoordinateTextBox.Text), Convert.ToInt32(YCoordinateTextBox.Text)));
                    _rectangles[(int)RectListBox.SelectedIndex] = _currentRectangle;
                }
                catch
                {
                    LenghtTextBox.BackColor = Color.LightPink;
                }
            }
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (DurationTextBox.Text != "" && YearTextBox.Text != "" && RatingTextBox.Text != "" && GenreTextBox.Text != "" && TitleTextBox.Text != "")
            {
                try
                {
                    RatingTextBox.BackColor = Color.White;
                    _currentMovie = new Models.Classes.Movie(
                        TitleTextBox.Text,
                        Convert.ToInt32(DurationTextBox.Text),
                        Convert.ToInt32(YearTextBox.Text),
                        GenreTextBox.Text,
                        Convert.ToInt32(RatingTextBox.Text));
                    _movie[(int)MovieListBox.SelectedIndex] = _currentMovie;
                }
                catch
                {
                    RatingTextBox.BackColor = Color.LightPink;
                }

            }
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            if (DurationTextBox.Text != "" && YearTextBox.Text != "" && RatingTextBox.Text != "" && GenreTextBox.Text != "" && TitleTextBox.Text != "")
            {
                try
                {
                    GenreTextBox.BackColor = Color.White;
                    _currentMovie = new Models.Classes.Movie(
                        TitleTextBox.Text,
                        Convert.ToInt32(DurationTextBox.Text),
                        Convert.ToInt32(YearTextBox.Text),
                        GenreTextBox.Text,
                        Convert.ToInt32(RatingTextBox.Text));
                    _movie[(int)MovieListBox.SelectedIndex] = _currentMovie;
                }
                catch
                {
                    GenreTextBox.BackColor = Color.LightPink;
                }

            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Random _random = new Random();
            var rectangle = RectangleFactory.Randomize();
            var panel = new Panel();

            var info = TakeInfoFromRectangle(rectangle);

            _rectanglesList.Add(rectangle);
            RectanglesListBox.Items.Add(info);

            panel.Height = Convert.ToInt32(rectangle.Lenght);
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
                       $"L={rectangle.Lenght})";

            return info;
        }

        //TODO: объяснить почему передача по ссылке
        private void UpdateRectangleInfo(ref Rectangle rectangle)
        {
            rectangle = _rectanglesList[RectanglesListBox.SelectedIndex];

            IddTextBox.Text = rectangle.Id.ToString();
            XTextBox.Text = rectangle.Center.X.ToString();
            YTextBox.Text = rectangle.Center.Y.ToString();
            WhTextBox.Text = rectangle.Width.ToString();
            HeightTextBox.Text = rectangle.Lenght.ToString();
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
                    if( i != j)
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

                _currentRectangleFromList.Lenght = heightDouble;
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