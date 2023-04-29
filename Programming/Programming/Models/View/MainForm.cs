using Programming.Models.Classes;
using Programming.Models.Enums;
using Rectangle = Programming.Models.Classes.Rectangle;

namespace Programming
{
    public partial class MainForm : Form
    {
        
        string[] enums = { "Colors", "EducationForm", "Genre", "Menufactures", "Season", "Weekday" };
        private Rectangle[] _rectangles;
        private Movie[] _movie;
        private Rectangle _currentRectangle = new Rectangle();
        private Movie _currentMovie = new Movie();
        private string[] _colors = { "Orange", "Black", "Red", "Green", "Blue" };
        private int max = 0;
        public MainForm()
        {
            _rectangles = new Rectangle[5];
            _movie = new Movie[5];
            InitializeComponent();
            InitRectanglesAndMovies();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            EnumsListBox.Items.AddRange(enums);
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
                    ValueListBox.Items.AddRange(typeof(Menufactures).GetEnumNames());
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
                ParseLabel.Text = $"«Это день недели ({week} = {((int)week + 1)})»";
            else ParseLabel.Text = "Нет такого дня недели!";
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            string selectedSeason = SeasonComboBox.SelectedItem.ToString();
            switch (selectedSeason)
            {
                case "Winter":
                    MessageBox.Show("Брр, холодища!");
                    break;
                case "Summer":
                    MessageBox.Show("Ура! Солнце!");
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
            max = 0;
            int index = 0;
            for (int i = 0; i < _rectangles.Length; i++)
            {
                if (max < _rectangles[i].FindRectangleWithMaxWidth())
                {
                    max = _rectangles[i].FindRectangleWithMaxWidth();
                    index = i;

                }
            }
            MessageBox.Show($"Наибольший прямоугольник с индексом - {index}");
            RectListBox.SetSelected(index, true);
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LenghtTextBox.Text != "" && WidthTextBox.Text != "" && ColorTextBox.Text != "")
            {
                try
                {
                    ColorTextBox.BackColor = Color.White;
                    _currentRectangle = new Models.Classes.Rectangle(
                        Convert.ToInt32(LenghtTextBox.Text), 
                        Convert.ToInt32(WidthTextBox.Text), ColorTextBox.Text);
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
            if (LenghtTextBox.Text != "" && WidthTextBox.Text != "" && ColorTextBox.Text != "" && IdTextBox.Text != "")
            {
                try
                {
                    WidthTextBox.BackColor = Color.White;
                    _currentRectangle = new Models.Classes.Rectangle(
                        Convert.ToInt32(LenghtTextBox.Text), 
                        Convert.ToInt32(WidthTextBox.Text),
                        ColorTextBox.Text);
                    Point2D ct = _rectangles[RectListBox.SelectedIndex].Center();
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
            ColorTextBox.Text = answr.Color.ToString();
            LenghtTextBox.Text = answr.Lenght.ToString();
            WidthTextBox.Text = answr.Width.ToString();
            IdTextBox.Text = answr.Id.ToString();
            _currentRectangle = _rectangles[(int)RectListBox.SelectedIndex];
        }

        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            max = 0;
            int index = 0;
            for (int i = 0; i < _movie.Length; i++)
            {
                if (max < _movie[i].FindMovieWithMaxRating())
                {
                    max = _movie[i].FindMovieWithMaxRating();
                    index = i;

                }

            }
            MessageBox.Show($"Самый рейтинговый фильм с индексом - {index}");
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
                    Convert.ToDouble(rd.Next(1, 244)), _colors[rd.Next(0, 4)]);

                RectListBox.Items[i] = ($"Rectangle {i + 1}");
            }
            RectListBox.SetSelected(0, true);
            var Movie = new[]
            {
                new Movie("Дракула", 320, 1999, "Ужасы", 7),
                new Movie("Золушка", 170, 1989, "Мультфильм", 8),
                new Movie("Зебра", 620, 2013, "Научный", 5),
                new Movie("Аватар2", 330, 2023, "Фантастика", 9),
                new Movie("Пинокио", 120, 2013, "Мультфильм", 6)
            };
            _movie = Movie.ToArray();
            for (int j = 0; j < _movie.Length; j++)
            {
                MovieListBox.Items[j] = ($"Фильм {j + 1}");
            }

            MovieListBox.SetSelected(0, true);
        }
    }
}