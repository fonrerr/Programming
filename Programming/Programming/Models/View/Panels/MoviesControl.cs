using Programming.Models.Classes;

namespace Programming.Models.View.Panels
{
    public partial class MoviesControl : UserControl
    {
        private Movie _currentMovie = new Movie();
        private Movie[] _movie;
        private int _max = 0;

        public MoviesControl()
        {
            _movie = new Movie[5];
            InitializeComponent();
            InitRectanglesAndMovies();
        }

        private void InitRectanglesAndMovies()
        {
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
                    DurationTextBox.BackColor = AppColors.ErrorColor;
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
                    YearTextBox.BackColor = AppColors.ErrorColor;
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
                    GenreTextBox.BackColor = AppColors.ErrorColor;
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
                    RatingTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }
    }
}
